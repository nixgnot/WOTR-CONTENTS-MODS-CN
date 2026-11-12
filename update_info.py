#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
自动更新 info.json 文件的脚本
扫描 QuickLocalization用汉化文本 目录下的文件，更新文件列表和最后修改时间
"""

import os
import re
import sys
import json
import subprocess
from datetime import datetime
from functools import lru_cache
from pathlib import Path


def get_git_last_commit_time(file_path):
    """获取指定路径的最后提交时间，返回C#友好的格式"""
    try:
        # 使用git log获取指定路径的最后提交时间
        cmd = ['git', 'log', '-1', '--format=%aI', '--', file_path]
        result = subprocess.run(cmd, capture_output=True, text=True, cwd=os.getcwd())
        
        if result.returncode == 0 and result.stdout.strip():
            git_time = result.stdout.strip()
        else:
            # 如果没有找到该路径的提交，使用全局最新提交时间
            cmd = ['git', 'log', '-1', '--format=%aI']
            result = subprocess.run(cmd, capture_output=True, text=True, cwd=os.getcwd())
            if result.returncode == 0 and result.stdout.strip():
                git_time = result.stdout.strip()
            else:
                # 如果git命令失败，使用当前时间
                return datetime.utcnow().strftime('%Y-%m-%dT%H:%M:%S.%fZ')
        
        # 转换为C#友好的时间格式
        try:
            # 解析git时间格式
            if git_time.endswith('Z'):
                # UTC时间格式
                dt = datetime.fromisoformat(git_time.replace('Z', '+00:00'))
            elif '+' in git_time[-6:] or '-' in git_time[-6:]:
                # 带时区的时间格式
                dt = datetime.fromisoformat(git_time)
            else:
                # 假设是UTC时间
                dt = datetime.fromisoformat(git_time + '+00:00')
            
            # 返回C#友好的格式：yyyy-MM-ddTHH:mm:ss.fffffffZ (UTC) 或 yyyy-MM-ddTHH:mm:ss.fffffffzzz (with timezone)
            if dt.tzinfo is None or dt.utctimetuple() == dt.replace(tzinfo=None).utctimetuple():
                # UTC时间
                return dt.strftime('%Y-%m-%dT%H:%M:%S.%fZ')
            else:
                # 带时区的时间
                return dt.strftime('%Y-%m-%dT%H:%M:%S.%f%z')
                
        except ValueError as e:
            print(f"解析时间格式失败 {git_time}: {e}")
            return datetime.utcnow().strftime('%Y-%m-%dT%H:%M:%S.%fZ')
            
    except Exception as e:
        print(f"获取 {file_path} 提交时间失败: {e}")
        return datetime.utcnow().strftime('%Y-%m-%dT%H:%M:%S.%fZ')


@lru_cache(maxsize=1)
def readme_index():
    """解析 README，返回 (小节 [(名称, 正文)], 表格短名 {名称: 短名})"""
    try:
        text = Path('README.md').read_text(encoding='utf-8')
    except OSError:
        return [], {}
    headings = list(re.finditer(r'^### \[([^\]]+)\]\([^)]*\)\s*$', text, re.M))
    sections = []
    for i, match in enumerate(headings):
        end = headings[i + 1].start() if i + 1 < len(headings) else len(text)
        sections.append((match.group(1), text[match.end():end]))
    rows = {
        m.group(1): m.group(2).strip()
        for m in re.finditer(r'^\| *\[([^\]]+)\]\(#[^)]+\) *\|([^|]*)\|', text, re.M)
    }
    return sections, rows


def readme_desc(target, kind):
    """用 README 对应 MOD 小节的「短名 - 简介」作 desc，找不到返回空串"""
    sections, rows = readme_index()
    needle = f'QuickLocalization用汉化文本/{kind}/{target}'
    label = body = None
    for section_label, section_body in sections:
        if needle in section_body:
            label, body = section_label, section_body
            break
    if label is None:
        for section_label, section_body in sections:
            if section_label == target:
                label, body = section_label, section_body
                break
    short = rows.get(label) if label else rows.get(target)
    intro = None
    if body:
        for line in body.splitlines():
            text = line.strip()
            if text.startswith('+ '):
                text = text[2:].strip()
                if text.startswith(('**注意', '特别注意', '**建议')):
                    continue
                intro = text.replace('<br>', '').strip()
                break
    if short and intro:
        return f'{short} - {intro}'
    return short or intro or ''


def scan_directory(base_path, target_list):
    """扫描指定目录，更新目标列表"""
    full_path = Path(base_path)
    kind = full_path.name  # Localization / TTTLocalization，用于匹配 README 链接
    print(f"\n扫描目录: {full_path}")
    
    if not full_path.exists():
        print(f"目录不存在: {full_path}")
        return
    
    # 获取所有子目录
    directories = [d for d in full_path.iterdir() if d.is_dir()]
    print(f"找到 {len(directories)} 个子目录: {[d.name for d in directories]}")
    
    for dir_path in directories:
        dir_name = dir_path.name
        
        # 查找目录下的所有JSON文件（排序，避免不同平台枚举顺序不同）
        json_files = sorted(f.name for f in dir_path.iterdir() if f.is_file() and f.suffix.lower() == '.json')
        
        print(f"  {dir_name}: {len(json_files)} 个JSON文件 {json_files}")
        
        if not json_files:
            print(f"    -> 跳过，没有JSON文件")
            continue
        
        # 获取最后提交时间
        relative_dir_path = str(dir_path).replace('\\', '/')
        last_update = get_git_last_commit_time(relative_dir_path)
        
        # 查找或创建目录条目
        existing_item = None
        for item in target_list:
            if item['target'] == dir_name:
                existing_item = item
                break
        
        if existing_item:
            # 更新现有条目
            old_files = existing_item.get('files', [])
            existing_item['files'] = json_files
            existing_item['lastUpdate'] = last_update
            # 描述为空（或只是目录名）时，用 README 重新生成
            if not existing_item.get('desc') or existing_item['desc'] == dir_name:
                existing_item['desc'] = readme_desc(dir_name, kind) or dir_name
            print(f"    -> 更新现有条目，文件变化: {len(old_files)} -> {len(json_files)}")
        else:
            # 创建新条目，描述自动从 README 生成
            desc = readme_desc(dir_name, kind)
            if not desc:
                desc = dir_name
                print(f"::warning:: {kind}/{dir_name} 在 README 中找不到介绍，desc 暂用目录名")
            new_item = {
                "desc": desc,
                "target": dir_name,
                "files": json_files,
                "lastUpdate": last_update
            }
            target_list.append(new_item)
            print(f"    -> 新增条目")


def main():
    """主函数"""
    print("=== 开始更新 info.json ===")
    
    # 读取现有的info.json
    info_path = Path('info.json')
    if info_path.exists():
        try:
            with open(info_path, 'r', encoding='utf-8') as f:
                info = json.load(f)
            print("成功读取现有 info.json")
        except Exception as e:
            print(f"读取 info.json 失败: {e}")
            print("创建新的结构")
            info = {
                "LocalizationList": [],
                "TTTLocalizationList": []
            }
    else:
        print("info.json 不存在，创建新的结构")
        info = {
            "LocalizationList": [],
            "TTTLocalizationList": []
        }
    
    # 扫描两个主要目录
    scan_directory('QuickLocalization用汉化文本/Localization', info['LocalizationList'])
    scan_directory('QuickLocalization用汉化文本/TTTLocalization', info['TTTLocalizationList'])
    
    # 按target名称排序
    info['LocalizationList'].sort(key=lambda x: x['target'])
    info['TTTLocalizationList'].sort(key=lambda x: x['target'])
    
    # 写入文件
    with open(info_path, 'w', encoding='utf-8') as f:
        json.dump(info, f, ensure_ascii=False, indent=2)
        f.write('\n')  # 添加换行符
    print(f"\ninfo.json 更新完成")

    # 显示统计信息
    print(f"\n=== 统计信息 ===")
    print(f"常规本地化目录数: {len(info['LocalizationList'])}")
    print(f"TTT本地化目录数: {len(info['TTTLocalizationList'])}")


def self_test():
    """断言 README 解析仍可用，防止 README 模板变化后静默回退目录名"""
    for target, kind in [
        ('WorldCrawl', 'Localization'),
        ('BrawlerClassWrath', 'Localization'),
        ('TTT-Base(Fix)', 'TTTLocalization'),
    ]:
        desc = readme_desc(target, kind)
        assert desc and desc != target, f'{target} 未从 README 解析出简介'
    print("✅ self-test 通过")


if __name__ == '__main__':
    try:
        if '--self-test' in sys.argv:
            self_test()
        else:
            main()
            print("\n✅ 更新完成")
    except Exception as e:
        print(f"\n❌ 执行失败: {e}")
        exit(1)

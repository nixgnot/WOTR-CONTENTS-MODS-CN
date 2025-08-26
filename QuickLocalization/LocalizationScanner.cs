using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityModManagerNet;

namespace QuickLocalization
{
    /// <summary>
    /// 配置文件结构
    /// </summary>
    public class DownloadConfig
    {
        /// <summary>
        /// 基础URL列表
        /// </summary>
        public List<string> BaseUrls { get; set; } = new List<string>();
        
        /// <summary>
        /// 相对路径配置
        /// </summary>
        public RelativePaths RelativePaths { get; set; } = new RelativePaths();
    }

    /// <summary>
    /// 相对路径配置
    /// </summary>
    public class RelativePaths
    {
        /// <summary>
        /// info.json相对路径
        /// </summary>
        public string Info { get; set; } = "info.json";
        
        /// <summary>
        /// 常规本地化相对路径
        /// </summary>
        public string Localization { get; set; } = "QuickLocalization用汉化文本/Localization";
        
        /// <summary>
        /// TTT本地化相对路径
        /// </summary>
        public string TttLocalization { get; set; } = "QuickLocalization用汉化文本/TTTLocalization";
    }

    /// <summary>
    /// 目录状态枚举
    /// </summary>
    public enum DirectoryStatus
    {
        /// <summary>
        /// 最新 - 本地和远程版本一致
        /// </summary>
        Latest,
        
        /// <summary>
        /// 有更新 - 远程版本比本地新
        /// </summary>
        HasUpdate,
        
        /// <summary>
        /// 未下载 - 远程有但本地没有
        /// </summary>
        NotDownloaded,
        
        /// <summary>
        /// 未记录 - 本地有但远程没有
        /// </summary>
        NotRecorded
    }

    /// <summary>
    /// 目录类型枚举
    /// </summary>
    public enum DirectoryType
    {
        /// <summary>
        /// 常规本地化
        /// </summary>
        Localization,
        
        /// <summary>
        /// TTT本地化
        /// </summary>
        TTTLocalization
    }

    /// <summary>
    /// 统一的目录项
    /// </summary>
    public class DirectoryItem
    {
        /// <summary>
        /// 目录名称
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 目录描述
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// 目录类型
        /// </summary>
        public DirectoryType Type { get; set; }
        
        /// <summary>
        /// 目录状态
        /// </summary>
        public DirectoryStatus Status { get; set; }
        
        /// <summary>
        /// 本地文件列表
        /// </summary>
        public List<string> LocalFiles { get; set; } = new List<string>();
        
        /// <summary>
        /// 远程文件列表
        /// </summary>
        public List<string> RemoteFiles { get; set; } = new List<string>();
        
        /// <summary>
        /// 本地最后修改时间
        /// </summary>
        public DateTime LocalLastModified { get; set; }
        
        /// <summary>
        /// 远程最后修改时间
        /// </summary>
        public DateTime RemoteLastModified { get; set; }
        
        /// <summary>
        /// 获取状态显示文本
        /// </summary>
        public string GetStatusText()
        {
            switch (Status)
            {
                case DirectoryStatus.Latest:
                    return "最新";
                case DirectoryStatus.HasUpdate:
                    return "有更新";
                case DirectoryStatus.NotDownloaded:
                    return "未下载";
                case DirectoryStatus.NotRecorded:
                    return "未记录";
                default:
                    return "未知";
            }
        }
        
        /// <summary>
        /// 获取操作按钮文本
        /// </summary>
        public string GetActionText()
        {
            switch (Status)
            {
                case DirectoryStatus.Latest:
                    return "覆盖";
                case DirectoryStatus.HasUpdate:
                    return "更新";
                case DirectoryStatus.NotDownloaded:
                    return "下载";
                case DirectoryStatus.NotRecorded:
                    return ""; // 不显示按钮
                default:
                    return "";
            }
        }
        
        /// <summary>
        /// 是否应该显示操作按钮
        /// </summary>
        public bool ShouldShowActionButton => Status != DirectoryStatus.NotRecorded;
    }

    /// <summary>
    /// JSON文件摘要
    /// </summary>
    public class JsonSummary
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Path { get; set; }
        
        /// <summary>
        /// 最后更新日期
        /// </summary>
        public DateTime LastModified { get; set; }
    }

    /// <summary>
    /// 数据目录摘要
    /// </summary>
    public class DirectorySummary
    {
        /// <summary>
        /// 路径ID
        /// </summary>
        public string PathId { get; set; }
        
        /// <summary>
        /// 所有扫描的JSON文件摘要列表
        /// </summary>
        public List<JsonSummary> JsonFiles { get; set; } = new List<JsonSummary>();
        
        /// <summary>
        /// 最后更新日期（所有JSON文件中最大的更新日期）
        /// </summary>
        public DateTime LastModified => JsonFiles.Count > 0 ? JsonFiles.Max(j => j.LastModified) : DateTime.MinValue;
        
        /// <summary>
        /// 是否标记为待更新
        /// </summary>
        public bool NeedsUpdate { get; set; }
    }

    /// <summary>
    /// 扫描结果数据
    /// </summary>
    public class ScanResult
    {
        /// <summary>
        /// 所有目录项列表（合并了本地和远程信息）
        /// </summary>
        public List<DirectoryItem> AllDirectories { get; set; } = new List<DirectoryItem>();
        
        /// <summary>
        /// 常规本地化目录摘要列表（保留用于兼容性）
        /// </summary>
        public List<DirectorySummary> LocalizationDirectories { get; set; } = new List<DirectorySummary>();
        
        /// <summary>
        /// TTT本地化目录摘要列表（保留用于兼容性）
        /// </summary>
        public List<DirectorySummary> TTTLocalizationDirectories { get; set; } = new List<DirectorySummary>();
        
        /// <summary>
        /// 远程信息是否可用
        /// </summary>
        public bool RemoteInfoAvailable { get; set; } = false;
        
        /// <summary>
        /// 远程信息获取错误消息
        /// </summary>
        public string RemoteInfoError { get; set; } = "";
    }

    /// <summary>
    /// GitHub仓库信息结构
    /// </summary>
    public class GitHubInfoItem
    {
        public string desc { get; set; }
        public string target { get; set; }
        public List<string> files { get; set; } = new List<string>();
        public string lastUpdate { get; set; }
        
        /// <summary>
        /// 获取最后更新时间
        /// </summary>
        public DateTime GetLastUpdateTime()
        {
            if (string.IsNullOrEmpty(lastUpdate))
                return DateTime.MinValue;

            try
            {
                // 尝试多种时间格式解析
                DateTime result;
                
                // 1. 尝试直接解析 (支持ISO 8601格式)
                if (DateTime.TryParse(lastUpdate, out result))
                {
                    return result;
                }
                
                // 2. 尝试精确格式解析
                string[] formats = {
                    "yyyy-MM-ddTHH:mm:ss.fffffffZ",        // UTC with microseconds
                    "yyyy-MM-ddTHH:mm:ss.ffffffZ",         // UTC with 6 digits
                    "yyyy-MM-ddTHH:mm:ss.fffffZ",          // UTC with 5 digits
                    "yyyy-MM-ddTHH:mm:ss.ffffZ",           // UTC with 4 digits
                    "yyyy-MM-ddTHH:mm:ss.fffZ",            // UTC with milliseconds
                    "yyyy-MM-ddTHH:mm:ssZ",                // UTC without fractional seconds
                    "yyyy-MM-ddTHH:mm:ss.fffffffzzz",      // With timezone and microseconds
                    "yyyy-MM-ddTHH:mm:ss.ffffffzzz",       // With timezone and 6 digits
                    "yyyy-MM-ddTHH:mm:ss.fffffzzz",        // With timezone and 5 digits
                    "yyyy-MM-ddTHH:mm:ss.ffffzzz",         // With timezone and 4 digits
                    "yyyy-MM-ddTHH:mm:ss.fffzzz",          // With timezone and milliseconds
                    "yyyy-MM-ddTHH:mm:sszzz",              // With timezone without fractional seconds
                    "yyyy-MM-ddTHH:mm:ss.fffffffK",        // Generic timezone
                    "yyyy-MM-ddTHH:mm:ss.ffffffK",
                    "yyyy-MM-ddTHH:mm:ss.fffffK",
                    "yyyy-MM-ddTHH:mm:ss.ffffK",
                    "yyyy-MM-ddTHH:mm:ss.fffK",
                    "yyyy-MM-ddTHH:mm:ssK"
                };
                
                foreach (var format in formats)
                {
                    if (DateTime.TryParseExact(lastUpdate, format, null, System.Globalization.DateTimeStyles.RoundtripKind, out result))
                    {
                        return result;
                    }
                }
                
                // 3. 尝试DateTimeOffset解析然后转换为DateTime
                if (DateTimeOffset.TryParse(lastUpdate, out DateTimeOffset offsetResult))
                {
                    return offsetResult.DateTime;
                }
                
                // 如果所有解析都失败，返回最小值
                return DateTime.MinValue;
            }
            catch
            {
                // 解析失败，返回最小值
                return DateTime.MinValue;
            }
        }
    }

    /// <summary>
    /// GitHub仓库info.json结构
    /// </summary>
    public class GitHubInfo
    {
        public List<GitHubInfoItem> LocalizationList { get; set; } = new List<GitHubInfoItem>();
        public List<GitHubInfoItem> TTTLocalizationList { get; set; } = new List<GitHubInfoItem>();
    }

    /// <summary>
    /// 本地化文件扫描器
    /// </summary>
    public class LocalizationScanner
    {
        private readonly HttpClient _httpClient;
        private DownloadConfig _config;
        
        /// <summary>
        /// 日志记录器
        /// </summary>
        public UnityModManager.ModEntry.ModLogger Logger { get; set; }

        public LocalizationScanner(UnityModManager.ModEntry modEntry)
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "QuickLocalization/1.0");
            Logger = modEntry.Logger;
            LoadConfig(modEntry);
        }

        /// <summary>
        /// 加载配置文件
        /// </summary>
        private void LoadConfig(UnityModManager.ModEntry modEntry)
        {
            try
            {
                var configPath = Path.Combine(modEntry.Path, "config.json");
                if (File.Exists(configPath))
                {
                    var configJson = File.ReadAllText(configPath);
                    _config = JsonConvert.DeserializeObject<DownloadConfig>(configJson);
                    Logger?.Log($"成功加载配置文件: {configPath}");
                }
                else
                {
                    Logger?.Log($"配置文件不存在，使用默认配置: {configPath}");
                    _config = new DownloadConfig
                    {
                        BaseUrls = new List<string>
                        {
                            "https://raw.githubusercontent.com/magicskysword/WOTR-CONTENTS-MODS-CN/main",
                            "https://cdn.jsdelivr.net/gh/magicskysword/WOTR-CONTENTS-MODS-CN@main"
                        },
                        RelativePaths = new RelativePaths()
                    };
                }
            }
            catch (Exception ex)
            {
                Logger?.Error($"加载配置文件失败: {ex.Message}");
                _config = new DownloadConfig
                {
                    BaseUrls = new List<string>
                    {
                        "https://raw.githubusercontent.com/magicskysword/WOTR-CONTENTS-MODS-CN/main",
                        "https://cdn.jsdelivr.net/gh/magicskysword/WOTR-CONTENTS-MODS-CN@main"
                    },
                    RelativePaths = new RelativePaths()
                };
            }
        }

        /// <summary>
        /// 通用文件下载方法，支持多个镜像站故障转移
        /// </summary>
        /// <param name="relativePath">相对路径</param>
        /// <returns>文件内容</returns>
        public async Task<string> DownloadFileWithFallback(string relativePath)
        {
            Exception lastException = null;

            foreach (var baseUrl in _config.BaseUrls)
            {
                try
                {
                    var fullUrl = $"{baseUrl.TrimEnd('/')}/{relativePath.TrimStart('/')}";
                    Logger?.Log($"尝试下载文件: {fullUrl}");
                    
                    var content = await _httpClient.GetStringAsync(fullUrl);
                    Logger?.Log($"成功下载文件: {fullUrl}");
                    
                    // 如果是info.json文件，显示部分内容用于调试
                    if (relativePath.Contains("info.json"))
                    {
                        var lines = content.Split('\n');
                        var previewLines = lines.Take(Math.Min(10, lines.Length));
                        Logger?.Log($"Info.json文件内容预览（前10行）:");
                        foreach (var line in previewLines)
                        {
                            Logger?.Log($"  {line.Trim()}");
                        }
                        Logger?.Log($"文件总大小: {content.Length} 字符");
                    }
                    
                    return content;
                }
                catch (Exception ex)
                {
                    Logger?.Error($"从 {baseUrl} 下载文件 {relativePath} 失败: {ex.Message}");
                    lastException = ex;
                }
            }

            throw new Exception($"无法从任何源下载文件 {relativePath}。最后一个错误: {lastException?.Message}", lastException);
        }

        /// <summary>
        /// 尝试从多个源获取info.json内容
        /// </summary>
        private async Task<GitHubInfo> GetGitHubInfoWithFallback()
        {
            var infoContent = await DownloadFileWithFallback(_config.RelativePaths.Info);
            var gitHubInfo = JsonConvert.DeserializeObject<GitHubInfo>(infoContent);
            
            Logger?.Log($"成功获取GitHub信息，常规条目数：{gitHubInfo.LocalizationList.Count}，TTT条目数：{gitHubInfo.TTTLocalizationList.Count}");
            
            // 添加调试信息：列出每个target及其文件数量
            Logger?.Log("=== 常规本地化目录调试信息 ===");
            foreach (var item in gitHubInfo.LocalizationList)
            {
                var fileCount = item.files?.Count ?? 0;
                Logger?.Log($"Target: {item.target}, 文件数量: {fileCount}, 描述: {item.desc}");
                if (fileCount > 0 && item.files != null)
                {
                    Logger?.Log($"  文件列表: [{string.Join(", ", item.files)}]");
                }
                else
                {
                    Logger?.Log($"  ⚠️ 无文件列表或文件为空");
                }
            }
            
            Logger?.Log("=== TTT本地化目录调试信息 ===");
            foreach (var item in gitHubInfo.TTTLocalizationList)
            {
                var fileCount = item.files?.Count ?? 0;
                Logger?.Log($"Target: {item.target}, 文件数量: {fileCount}, 描述: {item.desc}");
                if (fileCount > 0 && item.files != null)
                {
                    Logger?.Log($"  文件列表: [{string.Join(", ", item.files)}]");
                }
                else
                {
                    Logger?.Log($"  ⚠️ 无文件列表或文件为空");
                }
            }
            Logger?.Log("=== 调试信息结束 ===");
            
            return gitHubInfo;
        }

        /// <summary>
        /// 扫描本地JSON文件并与远程info.json进行双边比较
        /// </summary>
        /// <param name="modLocalizationDirectory">常规本地化目录</param>
        /// <param name="tttLocalizationDirectory">TTT本地化目录</param>
        /// <returns>扫描结果</returns>
        public async Task<ScanResult> ScanLocalFiles(string modLocalizationDirectory, string tttLocalizationDirectory)
        {
            var result = new ScanResult();

            Logger?.Log("开始双边扫描本地文件和远程信息...");

            // 1. 扫描本地目录
            var localDirectories = new Dictionary<string, DirectoryItem>();

            // 扫描常规本地化目录
            if (Directory.Exists(modLocalizationDirectory))
            {
                ScanLocalDirectory(modLocalizationDirectory, DirectoryType.Localization, localDirectories);
            }

            // 扫描TTT本地化目录
            if (Directory.Exists(tttLocalizationDirectory))
            {
                ScanLocalDirectory(tttLocalizationDirectory, DirectoryType.TTTLocalization, localDirectories);
            }

            // 2. 尝试获取远程info.json
            GitHubInfo gitHubInfo = null;
            bool remoteInfoAvailable = false;

            try
            {
                gitHubInfo = await GetGitHubInfoWithFallback();
                remoteInfoAvailable = true;
            }
            catch (Exception ex)
            {
                Logger?.Error($"获取远程信息失败: {ex.Message}");
                result.RemoteInfoError = ex.Message;
                remoteInfoAvailable = false;
            }

            // 3. 处理远程信息并进行双边比较
            var allDirectories = new Dictionary<string, DirectoryItem>();

            if (remoteInfoAvailable && gitHubInfo != null)
            {
                // 处理常规本地化列表
                ProcessRemoteInfo(gitHubInfo.LocalizationList, DirectoryType.Localization, localDirectories, allDirectories);

                // 处理TTT本地化列表
                ProcessRemoteInfo(gitHubInfo.TTTLocalizationList, DirectoryType.TTTLocalization, localDirectories, allDirectories);
            }
            else
            {
                Logger?.Log("远程信息不可用，将所有本地目录标记为未记录");
            }

            // 4. 处理只在本地存在的目录（未记录）
            foreach (var localDir in localDirectories.Values)
            {
                if (!allDirectories.ContainsKey(localDir.Name))
                {
                    localDir.Status = DirectoryStatus.NotRecorded;
                    allDirectories[localDir.Name] = localDir;
                }
            }

            // 5. 设置结果
            result.AllDirectories = allDirectories.Values.ToList();
            result.RemoteInfoAvailable = remoteInfoAvailable;

            // 保持兼容性，填充旧的结构
            result.LocalizationDirectories = result.AllDirectories
                .Where(d => d.Type == DirectoryType.Localization && d.Status != DirectoryStatus.NotDownloaded)
                .Select(ConvertToDirectorySummary)
                .ToList();

            result.TTTLocalizationDirectories = result.AllDirectories
                .Where(d => d.Type == DirectoryType.TTTLocalization && d.Status != DirectoryStatus.NotDownloaded)
                .Select(ConvertToDirectorySummary)
                .ToList();

            Logger?.Log($"双边扫描完成，总目录数: {result.AllDirectories.Count}，远程信息可用: {remoteInfoAvailable}");

            return result;
        }

        /// <summary>
        /// 扫描本地目录并添加到本地目录字典
        /// </summary>
        private void ScanLocalDirectory(string baseDirectory, DirectoryType type, Dictionary<string, DirectoryItem> localDirectories)
        {
            if (!Directory.Exists(baseDirectory))
                return;

            var directories = Directory.GetDirectories(baseDirectory);
            
            foreach (var dirPath in directories)
            {
                var dirName = Path.GetFileName(dirPath);
                var jsonFiles = Directory.GetFiles(dirPath, "*.json", SearchOption.AllDirectories);
                
                if (jsonFiles.Length == 0)
                    continue;

                var fileNames = jsonFiles.Select(f => Path.GetFileName(f)).ToList();
                var lastModified = jsonFiles.Select(f => File.GetLastWriteTime(f)).Max();

                var item = new DirectoryItem
                {
                    Name = dirName,
                    Description = "", // 本地没有描述信息
                    Type = type,
                    LocalFiles = fileNames,
                    LocalLastModified = lastModified,
                    Status = DirectoryStatus.NotRecorded // 默认为未记录，后续会更新
                };

                localDirectories[dirName] = item;
            }
        }

        /// <summary>
        /// 处理远程信息并与本地进行比较
        /// </summary>
        private void ProcessRemoteInfo(List<GitHubInfoItem> remoteList, DirectoryType type, 
            Dictionary<string, DirectoryItem> localDirectories, Dictionary<string, DirectoryItem> allDirectories)
        {
            foreach (var remoteItem in remoteList)
            {
                var item = new DirectoryItem
                {
                    Name = remoteItem.target,
                    Description = remoteItem.desc ?? "",
                    Type = type,
                    RemoteFiles = remoteItem.files ?? new List<string>(),
                    RemoteLastModified = remoteItem.GetLastUpdateTime()
                };

                // 检查是否存在对应的本地目录
                if (localDirectories.TryGetValue(remoteItem.target, out var localItem))
                {
                    // 合并本地和远程信息
                    item.LocalFiles = localItem.LocalFiles;
                    item.LocalLastModified = localItem.LocalLastModified;

                    // 确定状态
                    if (item.RemoteLastModified > item.LocalLastModified)
                    {
                        item.Status = DirectoryStatus.HasUpdate;
                    }
                    else
                    {
                        item.Status = DirectoryStatus.Latest;
                    }

                    // 从本地目录字典中移除，避免重复处理
                    localDirectories.Remove(remoteItem.target);
                }
                else
                {
                    // 远程有但本地没有
                    item.Status = DirectoryStatus.NotDownloaded;
                }

                allDirectories[remoteItem.target] = item;
            }
        }

        /// <summary>
        /// 将DirectoryItem转换为DirectorySummary（兼容性）
        /// </summary>
        private DirectorySummary ConvertToDirectorySummary(DirectoryItem item)
        {
            var summary = new DirectorySummary
            {
                PathId = item.Name,
                NeedsUpdate = item.Status == DirectoryStatus.HasUpdate
            };

            foreach (var fileName in item.LocalFiles)
            {
                summary.JsonFiles.Add(new JsonSummary
                {
                    Path = fileName,
                    LastModified = item.LocalLastModified
                });
            }

            return summary;
        }

        /// <summary>
        /// 扫描指定目录
        /// </summary>
        /// <param name="baseDirectory">基础目录</param>
        /// <returns>目录摘要列表</returns>
        private List<DirectorySummary> ScanDirectory(string baseDirectory)
        {
            var result = new List<DirectorySummary>();
            var directoryMap = new Dictionary<string, DirectorySummary>();

            // 获取所有JSON文件
            var jsonFiles = Directory.GetFiles(baseDirectory, "*.json", SearchOption.AllDirectories);

            foreach (var jsonFile in jsonFiles)
            {
                // 获取相对路径 (兼容 .NET Framework 4.7.2)
                var relativePath = GetRelativePath(baseDirectory, jsonFile);
                var pathParts = relativePath.Split(Path.DirectorySeparatorChar);

                // 只归类到一级目录
                var firstLevelDir = pathParts.Length > 1 ? pathParts[0] : "Root";

                // 创建或获取目录摘要
                if (!directoryMap.ContainsKey(firstLevelDir))
                {
                    directoryMap[firstLevelDir] = new DirectorySummary
                    {
                        PathId = firstLevelDir
                    };
                }

                // 添加JSON文件摘要
                var fileInfo = new FileInfo(jsonFile);
                directoryMap[firstLevelDir].JsonFiles.Add(new JsonSummary
                {
                    Path = relativePath,
                    LastModified = fileInfo.LastWriteTime
                });
            }

            result.AddRange(directoryMap.Values);
            return result;
        }

        /// <summary>
        /// 从GitHub获取info.json并比较更新状态
        /// </summary>
        /// <param name="scanResult">本地扫描结果</param>
        /// <returns>更新后的扫描结果</returns>
        public async Task<ScanResult> CheckUpdatesFromGitHub(ScanResult scanResult)
        {
            try
            {
                Logger?.Log("开始从GitHub检查更新...");
                
                // 使用故障转移机制获取GitHub信息
                var gitHubInfo = await GetGitHubInfoWithFallback();
                
                // 检查常规本地化目录
                CheckDirectoryUpdatesFromInfo(scanResult.LocalizationDirectories, gitHubInfo.LocalizationList);

                // 检查TTT本地化目录
                CheckDirectoryUpdatesFromInfo(scanResult.TTTLocalizationDirectories, gitHubInfo.TTTLocalizationList);
                
                // 标记远程信息可用
                scanResult.RemoteInfoAvailable = true;
                scanResult.RemoteInfoError = "";
                
                Logger?.Log("GitHub更新检查完成");
            }
            catch (Exception ex)
            {
                Logger?.Error($"从GitHub检查更新时出错: {ex}");
                scanResult.RemoteInfoAvailable = false;
                scanResult.RemoteInfoError = ex.Message;
            }

            return scanResult;
        }

        /// <summary>
        /// 检查目录更新状态（使用info.json中的信息）
        /// </summary>
        /// <param name="directories">本地目录摘要列表</param>
        /// <param name="gitHubList">GitHub信息列表</param>
        private void CheckDirectoryUpdatesFromInfo(List<DirectorySummary> directories, List<GitHubInfoItem> gitHubList)
        {
            Logger?.Log($"开始检查目录更新，本地目录数: {directories.Count}，GitHub条目数: {gitHubList.Count}");
            
            foreach (var directory in directories)
            {
                Logger?.Log($"检查目录: {directory.PathId}");
                
                // 在GitHub信息中查找对应的target
                var gitHubItem = gitHubList.FirstOrDefault(item => 
                {
                    // 直接匹配
                    if (item.target == directory.PathId) return true;
                    
                    // 匹配带括号的情况，如 "CharacterOptionsPlus(Fix)" 匹配 "CharacterOptionsPlus"
                    if (item.target.Contains("(") && item.target.StartsWith(directory.PathId + "(")) return true;
                    
                    // 匹配路径末尾的情况
                    if (item.target.EndsWith("/" + directory.PathId)) return true;
                    
                    return false;
                });

                if (gitHubItem != null)
                {
                    Logger?.Log($"找到匹配的GitHub条目: {gitHubItem.target}");
                    
                    var githubLastModified = gitHubItem.GetLastUpdateTime();
                    Logger?.Log($"GitHub最后修改时间: {githubLastModified}, 本地最后修改时间: {directory.LastModified}");
                    
                    // 比较时间，如果GitHub上的更新时间大于本地，则标记为待更新
                    if (githubLastModified > directory.LastModified)
                    {
                        directory.NeedsUpdate = true;
                        Logger?.Log($"目录 {directory.PathId} 需要更新: GitHub({githubLastModified}) > 本地({directory.LastModified})");
                    }
                    else
                    {
                        Logger?.Log($"目录 {directory.PathId} 无需更新");
                    }
                }
                else
                {
                    Logger?.Log($"未找到目录 {directory.PathId} 对应的GitHub条目");
                }
            }
        }

        /// <summary>
        /// 获取相对路径 (兼容 .NET Framework 4.7.2)
        /// </summary>
        /// <param name="fromPath">起始路径</param>
        /// <param name="toPath">目标路径</param>
        /// <returns>相对路径</returns>
        private string GetRelativePath(string fromPath, string toPath)
        {
            // 确保路径以目录分隔符结尾
            if (!fromPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                fromPath += Path.DirectorySeparatorChar;
            }

            var fromUri = new Uri(fromPath);
            var toUri = new Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme)
            {
                return toPath; // 不同的URI方案，返回绝对路径
            }

            var relativeUri = fromUri.MakeRelativeUri(toUri);
            var relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            // 将正斜杠转换为系统的目录分隔符
            return relativePath.Replace('/', Path.DirectorySeparatorChar);
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            _httpClient?.Dispose();
        }

        /// <summary>
        /// 下载单个目录的所有文件
        /// </summary>
        /// <param name="directoryItem">目录项</param>
        /// <param name="targetBasePath">目标基础路径</param>
        /// <param name="progressCallback">进度回调</param>
        /// <returns>是否成功</returns>
        public async Task<bool> DownloadDirectoryAsync(DirectoryItem directoryItem, string targetBasePath, Action<int, int> progressCallback = null)
        {
            try
            {
                Logger?.Log($"开始下载目录: {directoryItem.Name}");

                // 构建目标目录路径
                var targetDirectory = Path.Combine(targetBasePath, directoryItem.Name);
                
                // 如果目录不存在，创建目录
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                    Logger?.Log($"创建目录: {targetDirectory}");
                }

                // 获取远程文件列表
                var files = directoryItem.RemoteFiles ?? new List<string>();
                if (files.Count == 0)
                {
                    Logger?.Log($"目录 {directoryItem.Name} 没有文件需要下载");
                    progressCallback?.Invoke(0, 0);
                    return true;
                }

                // 下载每个文件
                int successCount = 0;
                for (int i = 0; i < files.Count; i++)
                {
                    var fileName = files[i];
                    progressCallback?.Invoke(i + 1, files.Count);
                    
                    try
                    {
                        var relativePath = $"{GetCorrectBasePath(directoryItem.Type)}/{directoryItem.Name}/{fileName}";
                        var fileContent = await DownloadFileWithFallback(relativePath);
                        
                        var targetFilePath = Path.Combine(targetDirectory, fileName);
                        File.WriteAllText(targetFilePath, fileContent);
                        
                        Logger?.Log($"成功下载文件: {fileName}");
                        successCount++;
                    }
                    catch (Exception ex)
                    {
                        Logger?.Error($"下载文件 {fileName} 失败: {ex.Message}");
                    }
                }

                Logger?.Log($"目录 {directoryItem.Name} 下载完成，成功: {successCount}/{files.Count}");
                return successCount > 0;
            }
            catch (Exception ex)
            {
                Logger?.Error($"下载目录 {directoryItem.Name} 时发生错误: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 更新单个目录（仅下载比本地更新的文件）
        /// </summary>
        /// <param name="directoryItem">目录项</param>
        /// <param name="targetBasePath">目标基础路径</param>
        /// <param name="progressCallback">进度回调</param>
        /// <returns>是否成功</returns>
        public async Task<bool> UpdateDirectoryAsync(DirectoryItem directoryItem, string targetBasePath, Action<int, int> progressCallback = null)
        {
            try
            {
                Logger?.Log($"开始更新目录: {directoryItem.Name}");

                // 检查远程更新时间
                if (directoryItem.RemoteLastModified == DateTime.MinValue)
                {
                    Logger?.Log($"目录 {directoryItem.Name} 无远程更新时间信息，跳过更新");
                    return false;
                }

                var remoteTime = directoryItem.RemoteLastModified;
                var localTime = directoryItem.LocalLastModified;

                if (remoteTime <= localTime)
                {
                    Logger?.Log($"目录 {directoryItem.Name} 本地版本已是最新，无需更新");
                    return true;
                }

                // 执行下载更新
                return await DownloadDirectoryAsync(directoryItem, targetBasePath, progressCallback);
            }
            catch (Exception ex)
            {
                Logger?.Error($"更新目录 {directoryItem.Name} 时发生错误: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 覆写单个目录（强制下载所有文件）
        /// </summary>
        /// <param name="directoryItem">目录项</param>
        /// <param name="targetBasePath">目标基础路径</param>
        /// <param name="progressCallback">进度回调</param>
        /// <returns>是否成功</returns>
        public async Task<bool> OverwriteDirectoryAsync(DirectoryItem directoryItem, string targetBasePath, Action<int, int> progressCallback = null)
        {
            try
            {
                Logger?.Log($"开始覆写目录: {directoryItem.Name}");

                // 构建目标目录路径
                var targetDirectory = Path.Combine(targetBasePath, directoryItem.Name);
                
                // 如果目录存在，先删除
                if (Directory.Exists(targetDirectory))
                {
                    Directory.Delete(targetDirectory, true);
                    Logger?.Log($"删除现有目录: {targetDirectory}");
                }

                // 执行下载
                return await DownloadDirectoryAsync(directoryItem, targetBasePath, progressCallback);
            }
            catch (Exception ex)
            {
                Logger?.Error($"覆写目录 {directoryItem.Name} 时发生错误: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 获取正确的基础路径
        /// </summary>
        /// <param name="type">目录类型</param>
        /// <returns>基础路径</returns>
        private string GetCorrectBasePath(DirectoryType type)
        {
            return type switch
            {
                DirectoryType.Localization => _config.RelativePaths.Localization,
                DirectoryType.TTTLocalization => _config.RelativePaths.TttLocalization,
                _ => "QuickLocalization用汉化文本/Localization"
            };
        }
    }
}

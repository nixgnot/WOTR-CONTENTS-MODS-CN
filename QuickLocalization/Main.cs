using HarmonyLib;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.Localization;
using Kingmaker.Localization.Shared;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityModManagerNet;
using static UnityModManagerNet.UnityModManager.ModEntry;

namespace QuickLocalization
{
    public static class Main
    {
        public static bool Enabled;
        public static string ModLocalizationDirectory;
        public static string TTTLocalizationDirectory;
        public static string AllModDirectory;
        public static ModLogger Logger;
        public static List<LocalizationException> Exceptions = new List<LocalizationException>();
        public static List<LocalizationWarning> Warnings = new List<LocalizationWarning>();
        public static int AllTextCount = 0;
        public static int SuccessLoadCount = 0;
        public static bool Editable = false;
        public static LocalizationScanner Scanner;
        public static ScanResult LastScanResult;
        
        // 下载进度跟踪
        public static Dictionary<string, DownloadProgress> DownloadProgressDict = new Dictionary<string, DownloadProgress>();

        public class DownloadProgress
        {
            public bool IsDownloading { get; set; }
            public int CurrentFile { get; set; }
            public int TotalFiles { get; set; }
            public string Status { get; set; } // "下载中", "完成", "失败"
        }

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            try
            {
                Logger = modEntry.Logger;
                modEntry.OnToggle = OnToggle;
                modEntry.OnGUI = OnGUI;
                ModLocalizationDirectory = $"{modEntry.Path}Localization";
                TTTLocalizationDirectory = $"{modEntry.Path}TTTLocalization";
                AllModDirectory = $"{modEntry.Path}..";
                Logger.Log(ModLocalizationDirectory);
                Scanner = new LocalizationScanner(modEntry);
                var harmony = new Harmony(modEntry.Info.Id);
                harmony.PatchAll();
                Logger.Log("Finished patching.");
            }
            catch (Exception e)
            {
                Logger.Error($"Failed to patch {e}");
            }

            return true;
        }

        public static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            Enabled = value;
            if (!value)
            {
                // 清理资源
                Scanner?.Dispose();
                Scanner = null;
                LastScanResult = null;
                DownloadProgressDict.Clear();
            }
            return true;
        }

        public static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            GUILayout.Label($"<color=#00FFFF>成功加载文本：{SuccessLoadCount}/{AllTextCount}</color>");
            
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("重载本地化文本", GUILayout.Width(150f)))
            {
                Reload();
            }
            if (GUILayout.Button("检查更新", GUILayout.Width(150f)))
            {
                CheckUpdates();
            }
            GUILayout.EndHorizontal();

            // 显示扫描结果
            if (LastScanResult != null)
            {
                DisplayScanResults();
            }

            if (Exceptions.Count > 0 || Warnings.Count > 0)
            {
                GUILayout.BeginHorizontal();
                Editable = GUILayout.Toggle(Editable, "消息可编辑");
                GUILayout.EndHorizontal();
            }

            if (Exceptions.Count > 0)
            {
                GUILayout.Label("<color=#FF0000>本地化加载出现错误！</color>");
                if (GUILayout.Button("清空错误", GUILayout.Width(200f)))
                {
                    Exceptions.Clear();
                }

                GUILayout.BeginVertical("Box");
                foreach (var item in Exceptions)
                {
                    GUILayout.BeginHorizontal("Box");
                    MessageLabel(item.Message);
                    MessageLabel(item.InnerException?.ToString());
                    if (GUILayout.Button("复制", GUILayout.Width(50f)))
                    {
                        GUIUtility.systemCopyBuffer = $"{item.Message}\n{item.InnerException}";
                    }

                    GUILayout.EndHorizontal();
                }

                GUILayout.EndVertical();
            }

            if (Warnings.Count > 0)
            {
                GUILayout.Label("<color=#FFFF00>本地化加载出现警告！</color>");
                if (GUILayout.Button("清空警告", GUILayout.Width(200f)))
                {
                    Warnings.Clear();
                }

                GUILayout.BeginVertical("Box");
                foreach (var item in Warnings)
                {
                    GUILayout.BeginHorizontal("Box");
                    MessageLabel($"加载本地文件出现警告：{item.FileName}");
                    MessageLabel(item.Warning);
                    if (GUILayout.Button("复制", GUILayout.Width(50f)))
                    {
                        GUIUtility.systemCopyBuffer = $"加载本地文件出现警告：{item.FileName}\n{item.Warning}";
                    }

                    GUILayout.EndHorizontal();
                }

                GUILayout.EndVertical();
            }
        }

        public static void MessageLabel(string message)
        {
            if (!Editable)
            {
                GUILayout.Label(message);
            }
            else
            {
                GUILayout.TextArea(message, GUI.skin.label);
            }
        }

        public static void Reload()
        {
            AllTextCount = 0;
            SuccessLoadCount = 0;

            if (Directory.Exists(ModLocalizationDirectory))
            {
                var files = Directory.GetFiles(ModLocalizationDirectory, "*.json", SearchOption.AllDirectories);
                Logger.Log("读取本地化目录：" + ModLocalizationDirectory);
                foreach (var item in files)
                {
                    AllTextCount++;
                    try
                    {
                        Logger.Log($"加载本地化文件 {item}");
                        var json = File.ReadAllText(item);
                        var list = JsonConvert.DeserializeObject<List<MultiLocaleString>>(json);
                        var localizationPack = new MultiLocalizationPack();
                        list = Check(item, list);
                        localizationPack!.AddStrings(list);
                        LocalizationManager.CurrentPack.AddStrings(localizationPack!.GetCurrentPack());
                        SuccessLoadCount++;
                    }
                    catch (Exception e)
                    {
                        Logger.Error($"加载本地化文件失败 {item} \n {e}");
                        Exceptions.Add(new LocalizationException($"加载本地化文件失败 {item}", e));
                    }
                }
            }

            if (Directory.Exists(TTTLocalizationDirectory))
            {
                var tttFiles = Directory.GetFiles(TTTLocalizationDirectory, "*.json", SearchOption.AllDirectories);
                Logger.Log("读取TTT本地化目录：" + TTTLocalizationDirectory);
                foreach (var item in tttFiles)
                {
                    AllTextCount++;
                    try
                    {
                        Logger.Log($"加载本地化文件 {item}");
                        var json = File.ReadAllText(item);
                        var pack = JsonConvert.DeserializeObject<TTTMultiLocalizationPack>(json);
                        pack = Check(item, pack);
                        var modPath = pack.ModPath;
                        if (modPath != null)
                        {
                            var path = Path.Combine(AllModDirectory, modPath);
                            if (!File.Exists(path))
                            {
                                Logger.Log($"\t对应的语言文件不存在！ item = {item} TTT_Path={path}");
                                Warnings.Add(new LocalizationWarning(item, $"对应的语言文件不存在！ item = {item} TTT_Path={path}"));
                                continue;
                            }
                            Logger.Log($"\t存在对应语言文件：{path}，开始覆盖Key");
                            var rawJson = File.ReadAllText(path);
                            var rawLocalizationPack = JsonConvert.DeserializeObject<TTTMultiLocalizationPack>(rawJson);
                            var extraTranslation = new List<TTTMultiLocalizationPack.TTTMultiLocaleString>();
                            foreach (var multi in pack.Strings)
                            {
                                if (!string.IsNullOrEmpty(multi.SimpleName))
                                {
                                    var findRawMulti =
                                        rawLocalizationPack.Strings
                                            .FindAll(cur => cur.SimpleName.Equals(multi.SimpleName));
                                    if (findRawMulti.Count > 0)
                                    {
                                        // 记录所有SimpleName相同的本地化文本
                                        for (var index = 0; index < findRawMulti.Count; index++)
                                        {
                                            var localeString = findRawMulti[index];
                                            var newLocaleString = multi.Clone();
                                            newLocaleString.Key = localeString.Key;
                                            extraTranslation.Add(newLocaleString);
                                        }
                                    }
                                    else
                                    {
                                        extraTranslation.Add(multi);
                                    }
                                }
                                else
                                {
                                    extraTranslation.Add(multi);
                                }
                            }

                            pack.Strings.Clear();
                            pack.Strings.AddRange(extraTranslation);
                        }
                        else
                        {
                            Logger.Log("\t不存在对应语言文件，直接加载");
                        }

                        var localizationPack = new MultiLocalizationPack();
                        localizationPack!.AddStrings(pack.GetMulStringList());
                        LocalizationManager.CurrentPack.AddStrings(localizationPack!.GetCurrentPack());
                        SuccessLoadCount++;
                    }
                    catch (Exception e)
                    {
                        Logger.Error($"加载本地化文件 {item} 失败：{e}");
                        Exceptions.Add(new LocalizationException($"加载TTT本地化文件 {item} 失败", e));
                    }
                }
            }
        }

        private static List<MultiLocaleString> Check(string fileName, List<MultiLocaleString> list)
        {
            var dic = new Dictionary<string, MultiLocaleString>();
            var newList = new List<MultiLocaleString>();
            foreach (var item in list)
            {
                if (dic.ContainsKey(item.Key))
                {
                    Warnings.Add(new LocalizationWarning(fileName,
                        $"重复的文本Key：{item.Key} 内容：{JsonConvert.SerializeObject(item)}"));
                }

                dic[item.Key] = item;
            }

            newList.AddRange(dic.Values);
            return newList;
        }

        private static TTTMultiLocalizationPack Check(string fileName, TTTMultiLocalizationPack pack, bool addWarning = true)
        {
            var newPack = new TTTMultiLocalizationPack();
            newPack.ModPath = pack.ModPath;

            var dic = new Dictionary<string, TTTMultiLocalizationPack.TTTMultiLocaleString>();
            foreach (var tttString in pack.Strings)
            {
                if (dic.ContainsKey(tttString.Key))
                {
                    if (addWarning)
                    {
                        Warnings.Add(new LocalizationWarning(fileName,
                            $"重复的文本Key：{tttString.Key} 内容：{JsonConvert.SerializeObject(tttString)}"));
                    }
                }

                dic[tttString.Key] = tttString;
            }

            var hashSet = new HashSet<string>();
            foreach (var tttString in pack.Strings)
            {
                if (!string.IsNullOrEmpty(tttString.SimpleName))
                {
                    if (hashSet.Contains(tttString.SimpleName))
                    {
                        if (addWarning)
                        {
                            Warnings.Add(new LocalizationWarning(fileName,
                                $"重复的文本SimpleName：{tttString.SimpleName} 内容：{JsonConvert.SerializeObject(tttString)}"));
                        }
                        dic.Remove(tttString.Key);
                    }

                    hashSet.Add(tttString.SimpleName);
                }
            }

            newPack.Strings.AddRange(dic.Values);
            return newPack;
        }

        public static async void ScanFiles()
        {
            try
            {
                Logger.Log("开始扫描本地文件...");
                LastScanResult = await Scanner.ScanLocalFiles(ModLocalizationDirectory, TTTLocalizationDirectory);
                Logger.Log($"扫描完成: 常规目录 {LastScanResult.LocalizationDirectories.Count} 个, TTT目录 {LastScanResult.TTTLocalizationDirectories.Count} 个, 总目录 {LastScanResult.AllDirectories.Count} 个");
            }
            catch (Exception ex)
            {
                Logger.Error($"扫描文件时出错: {ex}");
                Exceptions.Add(new LocalizationException("扫描文件失败", ex));
            }
        }

        public static async void CheckUpdates()
        {
            try
            {
                if (LastScanResult == null)
                {
                    ScanFiles();
                }

                if (LastScanResult != null)
                {
                    Logger.Log("开始检查GitHub更新...");
                    LastScanResult = await Scanner.CheckUpdatesFromGitHub(LastScanResult);
                    Logger.Log("检查更新完成");
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"检查更新时出错: {ex}");
                Exceptions.Add(new LocalizationException("检查更新失败", ex));
            }
        }

        public static void DisplayScanResults()
        {
            if (LastScanResult == null) return;

            GUILayout.Label("<color=#FFFF00>本地化目录管理:</color>");
            
            // 显示远程信息状态
            if (!LastScanResult.RemoteInfoAvailable && !string.IsNullOrEmpty(LastScanResult.RemoteInfoError))
            {
                GUILayout.Label($"<color=#FF0000>⚠️ 无法获取远程更新信息: {LastScanResult.RemoteInfoError}</color>");
                GUILayout.Space(5);
            }
            
            if (LastScanResult.AllDirectories.Count > 0)
            {
                GUILayout.BeginVertical("Box");
                
                // 表头
                GUILayout.BeginHorizontal();
                GUILayout.Label("<color=#00FF00>目录名称</color>", GUILayout.Width(200));
                GUILayout.Label("<color=#00FF00>类型</color>", GUILayout.Width(80));
                GUILayout.Label("<color=#00FF00>状态</color>", GUILayout.Width(80));
                GUILayout.Label("<color=#00FF00>本地文件数</color>", GUILayout.Width(80));
                GUILayout.Label("<color=#00FF00>操作</color>", GUILayout.Width(80));
                GUILayout.EndHorizontal();
                
                // 分隔线
                GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(1));
                
                // 按类型和名称排序显示
                var sortedDirectories = LastScanResult.AllDirectories
                    .OrderBy(d => d.Type)
                    .ThenBy(d => d.Name)
                    .ToList();
                
                foreach (var dir in sortedDirectories)
                {
                    GUILayout.BeginHorizontal();
                    
                    // 目录名称 - 根据状态显示不同颜色
                    var nameColor = GetDirectoryNameColor(dir.Status);
                    var displayName = dir.Name;
                    if (displayName.Length > 25)
                        displayName = displayName.Substring(0, 22) + "...";
                    GUILayout.Label($"<color={nameColor}>{displayName}</color>", GUILayout.Width(200));
                    
                    // 类型
                    var typeText = dir.Type == DirectoryType.Localization ? "常规" : "TTT";
                    GUILayout.Label(typeText, GUILayout.Width(80));
                    
                    // 状态
                    var statusColor = GetStatusColor(dir.Status);
                    GUILayout.Label($"<color={statusColor}>{dir.GetStatusText()}</color>", GUILayout.Width(80));
                    
                    // 本地文件数
                    var fileCountText = dir.LocalFiles.Count > 0 ? dir.LocalFiles.Count.ToString() : "-";
                    GUILayout.Label(fileCountText, GUILayout.Width(80));
                    
                    // 操作按钮
                    if (DownloadProgressDict.ContainsKey(dir.Name))
                    {
                        // 显示下载进度
                        var progress = DownloadProgressDict[dir.Name];
                        if (progress.IsDownloading)
                        {
                            var progressText = progress.TotalFiles > 0 
                                ? $"下载中: {progress.CurrentFile}/{progress.TotalFiles}"
                                : "准备中...";
                            
                            var originalColor = GUI.backgroundColor;
                            GUI.backgroundColor = Color.blue;
                            GUILayout.Label(progressText, "Button", GUILayout.Width(80));
                            GUI.backgroundColor = originalColor;
                        }
                        else
                        {
                            // 显示完成或失败状态
                            var progressStatusColor = progress.Status == "完成" ? Color.green : Color.red;
                            var originalColor = GUI.backgroundColor;
                            GUI.backgroundColor = progressStatusColor;
                            GUILayout.Label(progress.Status, "Button", GUILayout.Width(80));
                            GUI.backgroundColor = originalColor;
                        }
                    }
                    else if (dir.ShouldShowActionButton)
                    {
                        var buttonColor = GetActionButtonColor(dir.Status);
                        var originalColor = GUI.backgroundColor;
                        GUI.backgroundColor = buttonColor;
                        
                        if (GUILayout.Button(dir.GetActionText(), GUILayout.Width(80)))
                        {
                            PerformDirectoryAction(dir);
                        }
                        
                        GUI.backgroundColor = originalColor;
                    }
                    else
                    {
                        GUILayout.Space(80);
                    }
                    
                    GUILayout.EndHorizontal();
                    
                    // 如果有描述信息，显示在下一行
                    if (!string.IsNullOrEmpty(dir.Description))
                    {
                        GUILayout.BeginHorizontal();
                        GUILayout.Space(20);
                        var desc = dir.Description;
                        if (desc.Length > 100)
                            desc = desc.Substring(0, 97) + "...";
                        GUILayout.Label($"<color=#CCCCCC><i>{desc}</i></color>");
                        GUILayout.EndHorizontal();
                    }
                    
                    GUILayout.Space(2);
                }
                
                GUILayout.EndVertical();
                
                // 统计信息
                GUILayout.Space(10);
                GUILayout.BeginHorizontal();
                var latestCount = LastScanResult.AllDirectories.Count(d => d.Status == DirectoryStatus.Latest);
                var updateCount = LastScanResult.AllDirectories.Count(d => d.Status == DirectoryStatus.HasUpdate);
                var notDownloadedCount = LastScanResult.AllDirectories.Count(d => d.Status == DirectoryStatus.NotDownloaded);
                var notRecordedCount = LastScanResult.AllDirectories.Count(d => d.Status == DirectoryStatus.NotRecorded);
                
                GUILayout.Label($"<color=#00FF00>最新: {latestCount}</color>");
                GUILayout.Label($"<color=#FFFF00>有更新: {updateCount}</color>");
                GUILayout.Label($"<color=#FF6600>未下载: {notDownloadedCount}</color>");
                GUILayout.Label($"<color=#FF0000>未记录: {notRecordedCount}</color>");
                
                // 显示远程信息状态
                if (LastScanResult.RemoteInfoAvailable)
                {
                    GUILayout.Label($"<color=#00FF00>远程信息: 可用</color>");
                }
                else
                {
                    GUILayout.Label($"<color=#FF0000>远程信息: 不可用</color>");
                }
                
                GUILayout.EndHorizontal();
            }
            else
            {
                GUILayout.Label("<color=#FFFF00>未找到本地化目录</color>");
            }
        }
        
        /// <summary>
        /// 获取目录名称颜色
        /// </summary>
        private static string GetDirectoryNameColor(DirectoryStatus status)
        {
            switch (status)
            {
                case DirectoryStatus.Latest:
                    return "#FFFFFF";
                case DirectoryStatus.HasUpdate:
                    return "#FFFF00";
                case DirectoryStatus.NotDownloaded:
                    return "#FF6600";
                case DirectoryStatus.NotRecorded:
                    return "#FF0000";
                default:
                    return "#FFFFFF";
            }
        }
        
        /// <summary>
        /// 获取状态颜色
        /// </summary>
        private static string GetStatusColor(DirectoryStatus status)
        {
            switch (status)
            {
                case DirectoryStatus.Latest:
                    return "#00FF00";
                case DirectoryStatus.HasUpdate:
                    return "#FFFF00";
                case DirectoryStatus.NotDownloaded:
                    return "#FF6600";
                case DirectoryStatus.NotRecorded:
                    return "#FF0000";
                default:
                    return "#FFFFFF";
            }
        }
        
        /// <summary>
        /// 获取操作按钮颜色
        /// </summary>
        private static UnityEngine.Color GetActionButtonColor(DirectoryStatus status)
        {
            switch (status)
            {
                case DirectoryStatus.Latest:
                    return UnityEngine.Color.gray;
                case DirectoryStatus.HasUpdate:
                    return UnityEngine.Color.yellow;
                case DirectoryStatus.NotDownloaded:
                    return UnityEngine.Color.green;
                default:
                    return UnityEngine.Color.white;
            }
        }
        
        /// <summary>
        /// 执行目录操作（下载/更新/覆盖）
        /// </summary>
        /// <param name="directory">目录项</param>
        private static async void PerformDirectoryAction(DirectoryItem directory)
        {
            try
            {
                Logger.Log($"开始执行操作: {directory.GetActionText()} - {directory.Name}");
                
                // 设置下载开始状态
                DownloadProgressDict[directory.Name] = new DownloadProgress
                {
                    IsDownloading = true,
                    CurrentFile = 0,
                    TotalFiles = directory.RemoteFiles?.Count ?? 0,
                    Status = "下载中"
                };
                
                // 确定目标基础路径
                string targetBasePath = directory.Type == DirectoryType.Localization 
                    ? ModLocalizationDirectory 
                    : TTTLocalizationDirectory;
                
                bool success = false;
                
                // 进度回调
                Action<int, int> progressCallback = (current, total) =>
                {
                    if (DownloadProgressDict.ContainsKey(directory.Name))
                    {
                        DownloadProgressDict[directory.Name].CurrentFile = current;
                        DownloadProgressDict[directory.Name].TotalFiles = total;
                    }
                };
                
                switch (directory.Status)
                {
                    case DirectoryStatus.NotDownloaded:
                        // 下载新目录
                        success = await Scanner.DownloadDirectoryAsync(directory, targetBasePath, progressCallback);
                        break;
                        
                    case DirectoryStatus.HasUpdate:
                        // 更新现有目录
                        success = await Scanner.UpdateDirectoryAsync(directory, targetBasePath, progressCallback);
                        break;
                        
                    case DirectoryStatus.Latest:
                        // 覆盖本地目录（强制重新下载）
                        success = await Scanner.OverwriteDirectoryAsync(directory, targetBasePath, progressCallback);
                        break;
                        
                    case DirectoryStatus.NotRecorded:
                        // 覆盖本地目录
                        success = await Scanner.OverwriteDirectoryAsync(directory, targetBasePath, progressCallback);
                        break;
                        
                    default:
                        Logger.Log($"目录 {directory.Name} 无需操作");
                        DownloadProgressDict.Remove(directory.Name);
                        return;
                }
                
                // 更新下载状态
                if (DownloadProgressDict.ContainsKey(directory.Name))
                {
                    DownloadProgressDict[directory.Name].IsDownloading = false;
                    DownloadProgressDict[directory.Name].Status = success ? "完成" : "失败";
                }
                
                if (success)
                {
                    Logger.Log($"成功{directory.GetActionText()}: {directory.Name}");
                    
                    // 操作成功后重载本地化文本
                    Logger.Log("操作完成，重新加载本地化文本...");
                    Reload();
                    
                    // 重新扫描文件状态
                    Logger.Log("重新扫描文件状态...");
                    ScanFiles();
                    
                    // 移除下载进度记录
                    DownloadProgressDict.Remove(directory.Name);
                }
                else
                {
                    Logger.Error($"操作失败: {directory.GetActionText()} - {directory.Name}");
                    
                    // 延迟移除失败状态，让用户看到失败信息
                    await Task.Delay(3000);
                    DownloadProgressDict.Remove(directory.Name);
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"执行目录操作时发生错误: {ex.Message}\n{ex.StackTrace}");
                
                // 清理下载状态
                if (DownloadProgressDict.ContainsKey(directory.Name))
                {
                    DownloadProgressDict[directory.Name].IsDownloading = false;
                    DownloadProgressDict[directory.Name].Status = "失败";
                    
                    // 延迟移除失败状态
                    await Task.Delay(3000);
                    DownloadProgressDict.Remove(directory.Name);
                }
            }
        }

        [HarmonyPatch(typeof(LocalizationManager), "WaitForInit")]
        internal class LocalizationLoader
        {
            [HarmonyPostfix]
            private static void Postfix()
            {
                Logger.Log($"开始加载文本");
                Reload();
                Logger.Log($"开始检查更新");
                CheckUpdates();
            }
        }
    }
}
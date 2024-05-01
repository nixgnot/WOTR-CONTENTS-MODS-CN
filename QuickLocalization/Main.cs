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
            return true;
        }

        public static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            GUILayout.Label($"<color=#00FFFF>成功加载文本：{SuccessLoadCount}/{AllTextCount}</color>");
            if (GUILayout.Button("重载本地化文本", GUILayout.Width(200f)))
            {
                Reload();
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

        [HarmonyPriority(Priority.Last)]
        [HarmonyPatch(typeof(LocalizationManager), "WaitForInit")]
        internal class LocalizationLoader
        {
            [HarmonyPostfix]
            private static void Postfix()
            {
                Logger.Log($"开始加载文本");
                Reload();
            }
        }
    }
}
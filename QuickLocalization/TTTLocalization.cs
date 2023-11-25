using JetBrains.Annotations;
using Kingmaker.Localization;
using Kingmaker.Localization.Shared;
using Kingmaker.PubSubSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickLocalization;

/// <summary>
/// Contains and manages localization for all available langauges.
/// </summary>
[JsonObject(MemberSerialization.OptIn)]
public class TTTMultiLocalizationPack {

    public TTTMultiLocalizationPack() { }
    
    /// <summary>
    /// All MultiLocaleStrings in the MultiLocalizationPack.
    /// </summary>
    [JsonProperty(PropertyName = "LocalizedStrings")]
    public List<TTTMultiLocaleString> Strings = new List<TTTMultiLocaleString>();
    [JsonProperty]
    public string ModPath;
    
    public List<MultiLocaleString> GetMulStringList()
    {
        var list = new List<MultiLocaleString>();
        var hashset = new HashSet<string>();
        foreach (var localeString in Strings)
        {
            if (hashset.Add(localeString.Key))
            {
                list.Add(new MultiLocaleString()
                {
                    Key = localeString.Key,
                    ProcessTemplates = localeString.ProcessTemplates,
                    enGB = localeString.enGB,
                    ruRU = localeString.ruRU,
                    deDE = localeString.deDE,
                    esES = localeString.esES,
                    frFR = localeString.frFR,
                    zhCN = localeString.zhCN,
                });
            }
        }

        return list;
    }

    /// <summary>
    /// Contains key used for LocalizedString as well as localized text for all supported lanagues.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class TTTMultiLocaleString {
        /// <summary>
        /// Key used for the resulting LocalizedString.
        /// </summary>
        [JsonProperty]
        public string Key;
        /// <summary>
        /// Used for human reference in the localization pack.
        /// </summary>
        [JsonProperty]
        public string SimpleName;
        /// <summary>
        /// Determines if the text will be passed though the tagging system before being added to the current LocalizationPack.
        /// </summary>
        [JsonProperty]
        public bool ProcessTemplates;
        /// <summary>
        /// English Text.
        /// </summary>
        [JsonProperty]
        public string enGB = "";
        /// <summary>
        /// Russian Text.
        /// </summary>
        [JsonProperty]
        public string ruRU;
        /// <summary>
        /// German Text.
        /// </summary>
        [JsonProperty]
        public string deDE;
        /// <summary>
        /// French Text.
        /// </summary>
        [JsonProperty]
        public string frFR;
        /// <summary>
        /// Chinese Text.
        /// </summary>
        [JsonProperty]
        public string zhCN;
        /// <summary>
        /// Spanish Text.
        /// </summary>
        [JsonProperty]
        public string esES;
        private LocalizedString m_LocalizedString;
        [JsonIgnore]
        public bool IsUsed = false;
        /// <summary>
        /// The LocalizedString representation of the the MultiLocaleString.
        /// </summary>
        public LocalizedString LocalizedString {
            get {
                m_LocalizedString ??= new LocalizedString {
                    m_Key = Key,
                    m_ShouldProcess = ProcessTemplates
                };
                IsUsed = true;
                return m_LocalizedString;
            }
        }
        public TTTMultiLocaleString() { }
        /// <summary></summary>
        /// <param name="simpleName">
        /// Used for human reference in the localization pack.
        /// </param>
        /// <param name="text">
        /// Initial text to include in the MultiLocaleString.
        /// </param>
        /// <param name="shouldProcess">
        /// Determines if the resulting LocalizedString will be processed by the tagging system.
        /// </param>
        /// <param name="locale">
        /// Locale to use for the initial text.
        /// </param>
        public TTTMultiLocaleString(string simpleName, string text, bool shouldProcess = false, Locale locale = Locale.enGB) {
            ProcessTemplates = shouldProcess;
            SimpleName = simpleName;
            Key = Guid.NewGuid().ToString("N");
            SetText(locale, text);
        }
        /// <summary>
        /// Sets to text for the specified locale.
        /// </summary>
        /// <param name="locale">
        /// Locale to set the text for.
        /// </param>
        /// <param name="text">
        /// Text to use for the specified locale.
        /// </param>
        public void SetText(Locale locale, string text) {
            switch (locale) {
                case Locale.enGB:
                    enGB = text;
                    break;
                case Locale.ruRU:
                    ruRU = text;
                    break;
                case Locale.deDE:
                    deDE = text;
                    break;
                case Locale.frFR:
                    frFR = text;
                    break;
                case Locale.zhCN:
                    zhCN = text;
                    break;
                case Locale.esES:
                    esES = text;
                    break;
                default:
                    enGB = text;
                    break;
            }
        }
        /// <summary>
        /// Generates a new StringEntry of the supplied locale.
        /// </summary>
        /// <param name="locale">
        /// Locale to use the text of.
        /// </param>
        /// <returns>
        /// StringEntry containing the text present in specified locale, or Locale.enGB if the text in the specified locale is null.
        /// </returns>
        public LocalizationPack.StringEntry StringEntry(Locale locale = Locale.enGB) {
            string result;
            switch (locale) {
                case Locale.enGB:
                    result = enGB;
                    break;
                case Locale.ruRU:
                    result = ruRU;
                    break;
                case Locale.deDE:
                    result = deDE;
                    break;
                case Locale.frFR:
                    result = frFR;
                    break;
                case Locale.zhCN:
                    result = zhCN;
                    break;
                case Locale.esES:
                    result = esES;
                    break;
                default:
                    result = enGB;
                    break;
            }
            if (string.IsNullOrEmpty(result)) {
                result = enGB;
            }
            return new LocalizationPack.StringEntry {
                //Text = ProcessTemplates ? EncyclopediaTool.TagEncyclopediaEntries(result) : result
                Text = result
            };
        }
        public override string ToString() {
            return this.StringEntry(LocalizationManager.CurrentLocale).Text;
        }
        public override int GetHashCode() {
            return Key.GetHashCode() ^ enGB.GetHashCode();
        }

        public TTTMultiLocaleString Clone()
        {
            return new TTTMultiLocaleString()
            {
                Key = Key,
                SimpleName = SimpleName,
                ProcessTemplates = ProcessTemplates,
                enGB = enGB,
                ruRU = ruRU,
                deDE = deDE,
                esES = esES,
                frFR = frFR,
                zhCN = zhCN,
            };
        }
    }
}

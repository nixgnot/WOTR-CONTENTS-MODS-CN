using System.Collections.Generic;
using Kingmaker.Localization;
using Kingmaker.Localization.Shared;
using Newtonsoft.Json;

namespace QuickLocalization;

public class MultiLocalizationPack
{
    //
    // 摘要:
    //     Dictionary of existing MultiLocaleStrings by Key.
    internal readonly Dictionary<string, MultiLocaleString> Strings = new Dictionary<string, MultiLocaleString>();

    internal void AddStrings(List<MultiLocaleString> strings)
    {
        foreach (MultiLocaleString @string in strings)
        {
            Strings.Add(@string.Key, @string);
        }
    }

    //
    // 摘要:
    //     Generates a new LocalizationPack based on the contents of the MultiLocalizationPack.
    internal LocalizationPack GetCurrentPack()
    {
        LocalizationPack localizationPack = new LocalizationPack
        {
            Locale = LocalizationManager.CurrentPack.Locale,
            m_Strings = new Dictionary<string, LocalizationPack.StringEntry>()
        };
        foreach (KeyValuePair<string, MultiLocaleString> @string in Strings)
        {
            var str = @string.Value.StringEntry(localizationPack.Locale);
            localizationPack.m_Strings[@string.Key] = str;
        }

        return localizationPack;
    }
}

//
// 摘要:
//     Contains key used for LocalizedString as well as localized text for all supported
//     lanagues.
[JsonObject(MemberSerialization.OptIn)]
public class MultiLocaleString
{
    //
    // 摘要:
    //     Key used to reference the string. Must be unique.
    [JsonProperty] public string Key = "";

    //
    // 摘要:
    //     Determines if the text will be passed though the tagging system before being
    //     added to the current LocalizationPack.
    [JsonProperty] public bool ProcessTemplates = true;

    //
    // 摘要:
    //     English Text.
    [JsonProperty] public string enGB = "";

    //
    // 摘要:
    //     Russian Text.
    [JsonProperty] public string ruRU = "";

    //
    // 摘要:
    //     German Text.
    [JsonProperty] public string deDE = "";

    //
    // 摘要:
    //     French Text.
    [JsonProperty] public string frFR = "";

    //
    // 摘要:
    //     Chinese Text.
    [JsonProperty] public string zhCN = "";

    //
    // 摘要:
    //     Spanish Text.
    [JsonProperty] public string esES = "";

    private LocalizedString m_LocalizedString;

    //
    // 摘要:
    //     The LocalizedString representation of the the MultiLocaleString.
    internal LocalizedString LocalizedString
    {
        get
        {
            if (m_LocalizedString == null)
            {
                m_LocalizedString = new LocalizedString
                {
                    m_Key = Key,
                    m_ShouldProcess = ProcessTemplates
                };
            }

            return m_LocalizedString;
        }
    }

    //
    // 摘要:
    //     Generates a new StringEntry of the supplied locale.
    //
    // 参数:
    //   locale:
    //     Locale to use the text of.
    //
    // 返回结果:
    //     StringEntry containing the text present in specified locale, or Locale.enGB if
    //     the text in the specified locale is null.
    internal LocalizationPack.StringEntry StringEntry(Locale locale = Locale.enGB)
    {
        bool flag = false;
        string text;
        switch (locale)
        {
            case Locale.enGB:
                text = enGB;
                break;
            case Locale.ruRU:
                text = ruRU;
                break;
            case Locale.deDE:
                text = deDE;
                break;
            case Locale.frFR:
                text = frFR;
                break;
            case Locale.zhCN:
                text = zhCN;
                break;
            case Locale.esES:
                text = esES;
                break;
            default:
                text = enGB;
                break;
        }

        if (string.IsNullOrEmpty(text))
        {
            text = enGB;
        }

        LocalizationPack.StringEntry result = default(LocalizationPack.StringEntry);
        result.Text = (flag ? EncyclopediaTool.TagEncyclopediaEntries(text) : text);
        return result;
    }

    public override string ToString()
    {
        return StringEntry(LocalizationManager.CurrentLocale).Text;
    }

    public override int GetHashCode()
    {
        return Key.GetHashCode() ^ enGB.GetHashCode();
    }
}
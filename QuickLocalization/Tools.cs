using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Kingmaker.Utility;
using Newtonsoft.Json;

namespace QuickLocalization
{
    public static class Tools
    {
        public static IEnumerable<TSource> Distinct<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer = null)
        {
            HashSet<TKey> hashSet;
            if (comparer != null)
            {
                hashSet = new HashSet<TKey>(comparer);
            }
            else
            {
                hashSet = new HashSet<TKey>();
            }
        
            foreach (TSource element in source)
            {
                if (hashSet.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }

    internal class MatchContext
    {
        public Match Match { get; }

        public string OriginalText { get; }

        public string Preceding { get; }

        public string Following { get; }

        public MatchContext(Match match, string originalText)
        {
            Match = match;
            OriginalText = originalText;
            Preceding = OriginalText.Substring(0, Match.Index);
            Following = OriginalText.Substring(Match.GetEnd());
        }

        public bool IsMatchStandaloneWord()
        {
            bool num = Preceding.Length <= 0 || char.IsWhiteSpace(Preceding.Last()) || char.IsPunctuation(Preceding.Last());
            bool flag = Following.Length <= 0 || char.IsWhiteSpace(Following.First()) || char.IsPunctuation(Following.First());
            return num && flag;
        }
    }

    internal static class MatchExtensions
    {
        public static int GetEnd(this Match match)
        {
            return match.Index + match.Length;
        }

        public static (int Start, int End) GetBounds(this Match match)
        {
            return (match.Index, match.GetEnd());
        }
    }



    //
    // 摘要:
    //     Tool for adding and removing encyclopedia entry tags from descriptions. Based
    //     on TabletopTweaks.Utilities.DescriptionTools by Vek17 - https://github.com/Vek17/WrathMods-TabletopTweaks/
    //
    // 言论：
    //     Currently only works in English.
    public static class EncyclopediaTool
    {

        internal class EncyclopediaEntry
        {
            public string Entry { get; }

            public List<string> Patterns { get; }

            public Regex EntryPattern { get; }

            public EncyclopediaEntry(string entry, List<string> patterns)
            {
                Entry = entry;
                Patterns = patterns;
                EntryPattern = new Regex("{g\\|Encyclopedia:" + Entry + "}(?<text>.*?){/g}");
            }

            public string TagEntry(string text)
            {
                foreach (string pattern in Patterns)
                {
                    foreach (Match item in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
                    {
                        if (item.Success)
                        {
                            MatchContext matchContext = new MatchContext(item, text);
                            if (matchContext.IsMatchStandaloneWord() && !IsAlreadyTagged(matchContext))
                            {
                                text = matchContext.Preceding + WrapTextInEntryTag(item.Value) + matchContext.Following;
                                return text;
                            }
                        }
                    }
                }

                return text;
            }

            public string UntagEntry(string text)
            {
                return EntryPattern.Replace(text, (Match m) => m.Groups["text"].Value);
            }

            private string WrapTextInEntryTag(string text)
            {
                return "{g|Encyclopedia:" + Entry + "}" + text + "{/g}";
            }

            public static bool IsAlreadyTagged(MatchContext context)
            {
                if (!Regex.IsMatch(context.Preceding, "{g\\|Encyclopedia:[\\w_]*}?\\Z"))
                {
                    return context.Following.StartsWith("{/g}");
                }

                return true;
            }
        }

        private static Lazy<EncyclopediaEntry[]> encyclopediaEntries = new Lazy<EncyclopediaEntry[]>(delegate
        {
            try
            {
                Assembly assembly = typeof(EncyclopediaTool).Assembly;
                string name = "resources.encyclopedia.json";
                using Stream stream = assembly.GetManifestResourceStream(name);
                using StreamReader streamReader = new StreamReader(stream);
                return JsonConvert.DeserializeObject<EncyclopediaEntry[]>(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Main.Logger.Error("Couldn't read file with Encyclopedia Entries! Message: " + ex.Message);
                throw ex;
            }
        });

        internal static EncyclopediaEntry[] EncyclopediaEntries => encyclopediaEntries.Value;

        //
        // 摘要:
        //     Returns text with encyclopedia entry tags (tooltips).
        //
        // 言论：
        //     If you create Kingmaker.Localization.LocalizedString using BlueprintCore.Utils.LocalizationTool
        //     this is automatically done.
        public static string TagEncyclopediaEntries(string text)
        {
            EncyclopediaEntry[] array = EncyclopediaEntries;
            for (int i = 0; i < array.Length; i++)
            {
                text = array[i].TagEntry(text);
            }

            return text;
        }

        //
        // 摘要:
        //     Returns text with encyclopedia entry tags (tooltips) removed.
        public static string UntagEncyclopediaEntries(string text)
        {
            EncyclopediaEntry[] array = EncyclopediaEntries;
            for (int i = 0; i < array.Length; i++)
            {
                text = array[i].UntagEntry(text);
            }

            return text;
        }
    }
}
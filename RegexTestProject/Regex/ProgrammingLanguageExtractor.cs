using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class ProgrammingLanguageExtractor
    {
        public List<string> ExtractLanguages(string text)
        {
            List<string> languages = new List<string>();

            string pattern = @"\b(JavaScript|Python|Java|Go)\b";

            MatchCollection matches = Regex.Matches(
                text,
                pattern,
                RegexOptions.IgnoreCase
            );

            foreach (Match match in matches)
            {
                languages.Add(match.Value);
            }

            return languages;
        }
    }
}

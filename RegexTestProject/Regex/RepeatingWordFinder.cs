using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class RepeatingWordFinder
    {
        public List<string> FindRepeatingWords(string text)
        {
            List<string> repeatingWords = new List<string>();

            string pattern = @"\b(\w+)\b\s+\b\1\b";

            MatchCollection matches = Regex.Matches(
                text,
                pattern,
                RegexOptions.IgnoreCase
            );

            foreach (Match match in matches)
            {
                repeatingWords.Add(match.Groups[1].Value);
            }

            return repeatingWords;
        }
    }
}

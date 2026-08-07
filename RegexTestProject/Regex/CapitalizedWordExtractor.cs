using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class CapitalizedWordExtractor
    {
        public List<string> ExtractCapitalizedWords(string text)
        {
            List<string> words = new List<string>();

            string pattern = @"\b[A-Z][a-zA-Z]*\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                words.Add(match.Value);
            }

            return words;
        }
    }
}

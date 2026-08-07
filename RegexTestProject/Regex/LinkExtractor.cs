using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class LinkExtractor
    {
        public List<string> ExtractLinks(string text)
        {
            List<string> links = new List<string>();

            string pattern = @"https?://[^\s]+";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                links.Add(match.Value);
            }

            return links;
        }
    }
}

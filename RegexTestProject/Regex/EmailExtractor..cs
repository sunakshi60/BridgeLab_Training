using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class EmailExtractor
    {
        public List<string> ExtractEmails(string text)
        {
            List<string> emails = new List<string>();

            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }

            return emails;
        }
    }
}

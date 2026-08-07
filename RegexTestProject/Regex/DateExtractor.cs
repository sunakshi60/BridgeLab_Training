using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class DateExtractor
    {
        public List<string> ExtractDates(string text)
        {
            List<string> dates = new List<string>();

            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                dates.Add(match.Value);
            }

            return dates;
        }
    }
}

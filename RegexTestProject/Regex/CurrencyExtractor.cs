using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class CurrencyExtractor
    {
        public List<string> ExtractCurrencyValues(string text)
        {
            List<string> values = new List<string>();

            string pattern = @"\$\s?\d+\.\d{2}";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string value = match.Value;

                if (value.Contains("$ "))
                {
                    value = value.Replace("$ ", "");
                }

                values.Add(value);
            }

            return values;
        }
    }
}

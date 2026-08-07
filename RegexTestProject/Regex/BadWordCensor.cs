using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class BadWordCensor
    {
        public string CensorBadWords(string text)
        {
            string pattern = @"\b(damn|stupid)\b";

            return Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
        }
    }
}

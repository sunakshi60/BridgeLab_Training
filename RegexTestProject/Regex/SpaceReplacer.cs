using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class SpaceReplacer
    {
        public string ReplaceMultipleSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
    }
}

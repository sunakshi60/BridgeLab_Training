using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class HexColorValidator
    {
        public bool ValidateHexColor(string color)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";

            return Regex.IsMatch(color, pattern);
        }
    }
}

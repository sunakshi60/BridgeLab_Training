using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class SSNValidator
    {
        public bool ValidateSSN(string ssn)
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            return Regex.IsMatch(ssn, pattern);
        }
    }
}

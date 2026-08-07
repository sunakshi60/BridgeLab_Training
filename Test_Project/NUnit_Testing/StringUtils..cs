using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public bool IsPalindrome(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            string reverse = new string(chars);

            return str.Equals(reverse, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}

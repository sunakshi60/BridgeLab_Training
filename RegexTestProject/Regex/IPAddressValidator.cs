using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class IPAddressValidator
    {
        public bool ValidateIPAddress(string ip)
        {
            string pattern =
                @"^((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])\.){3}" +
                @"(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9]?[0-9])$";

            return Regex.IsMatch(ip, pattern);
        }
    }
}

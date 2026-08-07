using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class LicensePlateValidator
    {
        public bool ValidateLicensePlate(string plateNumber)
        {
            string pattern = @"^[A-Z]{2}[0-9]{4}$";

            return Regex.IsMatch(plateNumber, pattern);
        }
    }
}

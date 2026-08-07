using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class CreditCardValidator
    {
        public bool ValidateCard(string cardNumber)
        {
            string pattern = @"^(4|5)\d{15}$";

            return Regex.IsMatch(cardNumber, pattern);
        }
    }
}

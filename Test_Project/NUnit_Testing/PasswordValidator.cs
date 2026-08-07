using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class PasswordValidator
    {
        public bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool hasUpperCase = false;
            bool hasDigit = false;
            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    hasUpperCase = true;
                }

                if (char.IsDigit(ch))
                {
                    hasDigit = true;
                }
            }
            return hasUpperCase && hasDigit;
        }
    }
}

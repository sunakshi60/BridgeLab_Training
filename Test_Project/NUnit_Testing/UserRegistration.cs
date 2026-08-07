using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class UserRegistration
    {
        public string RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new ArgumentException("Invalid email.");
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters.");
            }
            return "User Registered Successfully";
        }
    }
}

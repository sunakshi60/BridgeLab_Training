using System.Text.RegularExpressions;

namespace ValidateRegex
{
    public class UserNameValidator
    {
        public bool ValidateUsername(string username)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

            return Regex.IsMatch(username, pattern);
        }
    }
}

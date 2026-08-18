using System.Text;

namespace StringBuilderProblems
{
    public class ReverseString
    {
        public static string Reverse(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}
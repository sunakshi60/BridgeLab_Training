using System.Text;

namespace StringBuilderProblems
{
    public class RemoveDuplicates
    {
        public static string Remove(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char ch in input)
            {
                if (result.ToString().IndexOf(ch) == -1)
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
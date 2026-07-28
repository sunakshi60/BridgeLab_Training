using System;

namespace PracticeQues
{
	internal class CountVowelsAndConsonants
	{
		public static void Run()
		{
			Console.Write("Enter a string: ");
			string text = Console.ReadLine();
			Count(text, out int vowels, out int consonants);
			Console.WriteLine($"Vowels={vowels}");
			Console.WriteLine($"Consonants={consonants}");
		}

		private static void Count(string str,out int vowels, out int consonents)
		{
			vowels = 0;
			consonents = 0;
			str = str.ToLower();
			foreach(char ch in str){
				if (char.IsLetter(ch)) {
					if ("aeiou".Contains(ch))
						vowels++;
					else
						consonents++;
					}
				}
			}
		}
}
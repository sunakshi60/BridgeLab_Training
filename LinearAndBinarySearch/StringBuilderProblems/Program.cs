using System;

namespace StringBuilderProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter string for reverse: ");
            //string input1 = Console.ReadLine();
            //string reversed = ReverseString.Reverse(input1);
            //Console.WriteLine("Reversed String: " + reversed);


            //Console.Write("Enter string for removing duplicates: ");
            //string input2 = Console.ReadLine();
            //string unique = RemoveDuplicates.Remove(input2);
            //Console.WriteLine("After removing duplicates: " + unique);

            //StringConcatenation.Run();

            StringBuilderPerformance.Run();

            Console.ReadKey();
        }
    }
}
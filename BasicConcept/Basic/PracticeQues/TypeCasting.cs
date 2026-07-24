using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class TypeCasting
    {
        public static void ImplicitCasting()
        {
            Console.WriteLine("===== IMPLICIT CASTING =====");

            // Smaller datatype automatically converts into larger datatype
            int number = 100;
            double result = number;

            Console.WriteLine($"Integer Value : {number}");
            Console.WriteLine($"Converted Double Value : {result}");
        }

        public static void ExplicitCasting()
        {
            Console.WriteLine("\n===== EXPLICIT CASTING =====");

            // Larger datatype manually converts into smaller datatype
            double marks = 95.75;
            int finalMarks = (int)marks;

            Console.WriteLine($"Double Value : {marks}");
            Console.WriteLine($"Converted Integer Value : {finalMarks}");
        }
    }
}

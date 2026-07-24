using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class RefOut
    {
        internal static void RunDemo()
        {
            int[] marks = { 10, 20, 30, 40 };
            int totalMarks = 0;

            foreach (int mark in marks)
            {
                if (mark == 30)
                {
                    continue;
                }

                totalMarks += mark;
            }

            Console.WriteLine("Total marks (excluding 30) = " + totalMarks);

            int studentScore = 5;
            DoubleValue(ref studentScore);

            Console.WriteLine("Value after ref method = " + studentScore);

            GetDefaultNumber(out int generatedNumber);

            Console.WriteLine("Value received from out parameter = " + generatedNumber);
        }

        static void DoubleValue(ref int number)
        {
            number = number * 2;
        }

        static void GetDefaultNumber(out int number)
        {
            number = 100;
        }
    }
}

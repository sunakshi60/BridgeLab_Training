using System;

namespace PracticeProblems
{
    internal class OddEvenArrays
    {
        public static void Run()
        {
            Console.Write("PLease Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0 )
            {
                Console.Error.WriteLine("Invalid Number: Please Enter Natural number");
            }
            int size = number / 2 + 1;
            int[] EvenArray = new int [size];
            int[] OddArray = new int[size];
            int evenIndex = 0;
            int oddIndex = 0;
            for(int i = 1; i <= number; i++)
            {
                if (i%2==0)
                {
                    EvenArray[evenIndex++] = i;
                }
                else
                {
                    OddArray[oddIndex++] = i;
                }
            }
            Console.Write("Odd array: ");
            for(int i = 0; i < OddArray.Length; i++)
            {
                if (OddArray[i] != 0)
                {
                    Console.Write(OddArray[i] + " ");
                }
            }
            Console.Write("\nEven array: ");
            for (int i = 0; i < EvenArray.Length; i++)
            {
                if (EvenArray[i] != 0)
                {
                     Console.Write(EvenArray[i]  + " ");
                }
            }
        }
    }
}
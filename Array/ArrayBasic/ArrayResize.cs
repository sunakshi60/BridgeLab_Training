using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    internal class ArrayResize
    {
        public static void Resize()
        {
            int[] arr = new int[] { 10, 20, 30, 40 };
            Console.Write("Before resize: " );
            foreach(int i in arr)
            {
                Console.Write(+i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Length: " + arr.Length);
            Array.Resize(ref arr, 8);
            Console.Write("After resize: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Length = " + arr.Length);
        }
    }
}

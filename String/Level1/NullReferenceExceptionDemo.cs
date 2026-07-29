using System;

namespace Level1
{
    internal static class NullReferenceExceptionDemo
    {
        public static void Run()
        {
            try
            {
                DemonstrateException();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Exception Caught:");
                Console.WriteLine(ex.Message);
            }
        }

        private static void DemonstrateException()
        {
            string text = null;
            Console.WriteLine(text.ToUpper());
        }
    }
}
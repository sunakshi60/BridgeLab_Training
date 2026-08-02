using System;

namespace OverView
{
    // Working of Private Constructor
    // Prevents object creation from outside the class.

    class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("Private Constructor");
        }

        public static void Show()
        {
            Singleton obj = new Singleton();

            Console.WriteLine("Object Created Inside Class");
        }
    }
}
using System;

namespace OverView
{
    // Working of Static Constructor
    // Executes only once before the first object is created.

    class StudentStatic
    {
        static StudentStatic()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public StudentStatic()
        {
            Console.WriteLine("Default Constructor Called");
        }
    }
}
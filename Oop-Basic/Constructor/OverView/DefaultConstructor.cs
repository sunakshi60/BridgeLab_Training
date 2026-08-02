using System;

namespace OverView
{
    // Working of Default Constructor
    // Initializes object with default values.

    class StudentDefault
    {
        private string name;
        private int age;

        // Default Constructor
        public StudentDefault()
        {
            name = "Sunakshi";
            age = 21;
        }

        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
        }
    }
}
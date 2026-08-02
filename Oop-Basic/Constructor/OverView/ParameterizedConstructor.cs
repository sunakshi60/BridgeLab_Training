using System;

namespace OverView
{
    // Working of Parameterized Constructor
    // Initializes object with user-defined values.
    class StudentParameterized
    {
        private string name;
        private int age;

        //Parameterized Constructor
        public StudentParameterized(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Age : " + age);
            }
        }
}
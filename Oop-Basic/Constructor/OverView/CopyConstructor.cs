using System;

namespace OverView
{
    // Working of Copy Constructor
    // Creates a new object by copying another object.

    class StudentCopy
    {
        private string name;
        private int age;

        public StudentCopy(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy Constructor
        public StudentCopy(StudentCopy obj)
        {
            name = obj.name;
            age = obj.age;
        }

        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
        }
    }
}
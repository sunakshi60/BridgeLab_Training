using System;

namespace ReflectionProblems
{
    class Student
    {
        public string Name;
        private int Age;

        public Student()
        {
        }

        public Student(string name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("Student is studying.");
        }

        public void AttendClass()
        {
            Console.WriteLine("Student is attending class.");
        }
    }
}
using System;

namespace AccessModifiersQues
{
    class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;

        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public double GetCGPA()
        {
            return cgpa;
        }
    }

    class PostgraduateStudent : Student
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa)
        {
        }
        public void Display()
        {
            Console.WriteLine("Roll Number : " + rollNumber);
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("CGPA        : " + GetCGPA());
        }
    }
}
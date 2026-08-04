using System;

namespace PracticeProblems
{
    class Person
    {
        private string Name;
        private int Age;

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
        }
    }

    class Teacher : Person
    {
        private string Subject;

        public Teacher (string name,int age,string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("===== Teacher =====");
            base.DisplayRole();
            Console.WriteLine($"Subject : {Subject}");
        }
    }

    class Student : Person
    {
        private string Grade;

        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("===== Student =====");
            base.DisplayRole();
            Console.WriteLine($"Grade : {Grade}");
        }
    }

    class Staff : Person
    {
        private string Department;

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("===== Staff =====");
            base.DisplayRole();
            Console.WriteLine($"Department : {Department}");
        }
    }
}
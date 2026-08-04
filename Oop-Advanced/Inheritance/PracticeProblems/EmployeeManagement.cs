using System;

namespace PracticeProblems
{
    class Employee
    {
        private string Name;
        private int Id;
        private double Salary;

        public Employee(string name,int id,double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"ID     : {Id}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }

    class Manager : Employee
    {
        private int TeamSize;
        
        public Manager(string name,int id,double salary,int teamSize) : base(name,id,salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size : {TeamSize}");
        }
    }

    class Developer : Employee
    {
        private string ProgrammingLanguage;

        public Developer(string name, int id, double salary, string language) : base(name, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Programming Language : {ProgrammingLanguage}");
        }
    }

    class Intern : Employee
    {
        private string InternshipDuration;

        public Intern(string name,int id,double salary,string duration): base(name, id, salary)
        {
            InternshipDuration = duration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration : {InternshipDuration}");
        }
    }
}
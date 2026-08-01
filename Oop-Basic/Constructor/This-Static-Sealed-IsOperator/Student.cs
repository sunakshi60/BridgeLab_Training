using System;

namespace This_Static_Sealed_IsOperator
{
    class Student
    {
        static string universityName = "Chitkara University";
        static int totalStudents = 0;
        public readonly int rollNumber;
        string name;
        string grade;
        public Student(int rollNumber, string name, string grade)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.grade = grade;

            totalStudents++;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("University  : " + universityName);
            Console.WriteLine("Roll Number : " + rollNumber);
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("Grade       : " + grade);
        }
        public void UpdateGrade(string newGrade)
        {
            grade = newGrade;
            Console.WriteLine("\nGrade Updated Successfully.");
        }
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("\nTotal Students Enrolled : " + totalStudents);
        }
    }
}
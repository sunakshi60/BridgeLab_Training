using System;

namespace InstanceAndClassQues
{
    class Course
    {
        string courseName;
        int duration;
        double fee;

        static string instituteName = "BridgeLabz";

        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine("\nInstitute : " + instituteName);
            Console.WriteLine("Course    : " + courseName);
            Console.WriteLine("Duration  : " + duration + " Months");
            Console.WriteLine("Fee       : " + fee);
        }

        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }
    }
}
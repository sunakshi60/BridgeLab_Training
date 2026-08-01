using System;

namespace This_Static_Sealed_IsOperator
{
    class Patient
    {
        static string hospitalName = "City Hospital";
        static int totalPatients = 0;
        public readonly int patientID;
        string name;
        int age;
        string ailment;

        public Patient(int patientID, string name, int age, string ailment)
        {
            this.patientID = patientID;
            this.name = name;
            this.age = age;
            this.ailment = ailment;

            totalPatients++;
        }
        public void DisplayPatientDetails()
        {
            Console.WriteLine("\nPatient Details");
            Console.WriteLine("Hospital Name : " + hospitalName);
            Console.WriteLine("Patient ID    : " + patientID);
            Console.WriteLine("Name          : " + name);
            Console.WriteLine("Age           : " + age);
            Console.WriteLine("Ailment       : " + ailment);
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine("\nTotal Patients Admitted : " + totalPatients);
        }
    }
}
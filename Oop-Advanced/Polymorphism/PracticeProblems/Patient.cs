using System;

namespace PracticeProblems
{
    interface IMedicalRecord
    {
        void AddRecord(string diagnosis, string medicalHistory);
        void ViewRecords();
    }

    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        private string diagnosis;
        private string medicalHistory;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        protected string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        protected string MedicalHistory
        {
            get { return medicalHistory; }
            set { medicalHistory = value; }
        }

        public Patient(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Patient ID : {PatientId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Age        : {Age}");
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        private int daysAdmitted;
        private double roomChargePerDay;

        public InPatient(int id, string name, int age, int days, double roomCharge)
            : base(id, name, age)
        {
            daysAdmitted = days;
            roomChargePerDay = roomCharge;
        }

        public override double CalculateBill()
        {
            return daysAdmitted * roomChargePerDay;
        }

        public void AddRecord(string diagnosis, string medicalHistory)
        {
            Diagnosis = diagnosis;
            MedicalHistory = medicalHistory;
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Diagnosis      : {Diagnosis}");
            Console.WriteLine($"Medical History: {MedicalHistory}");
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee;

        public OutPatient(int id, string name, int age, double consultationFee)
            : base(id, name, age)
        {
            this.consultationFee = consultationFee;
        }

        public override double CalculateBill()
        {
            return consultationFee;
        }

        public void AddRecord(string diagnosis, string medicalHistory)
        {
            Diagnosis = diagnosis;
            MedicalHistory = medicalHistory;
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Diagnosis      : {Diagnosis}");
            Console.WriteLine($"Medical History: {MedicalHistory}");
        }
    }
}
using System;

namespace PracticeProblems
{
    interface IPayable
    {
        void PayBill();
    }

    class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Patient(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Patient ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    class InPatient : Patient
    {
        public int RoomNumber { get; set; }
        public int DaysAdmitted { get; set; }

        public InPatient(int id, string name, int age, int roomNumber, int daysAdmitted)
            : base(id, name, age)
        {
            RoomNumber = roomNumber;
            DaysAdmitted = daysAdmitted;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Days Admitted: {DaysAdmitted}");
        }
    }

    class OutPatient : Patient
    {
        public string AppointmentDate { get; set; }

        public OutPatient(int id, string name, int age, string appointmentDate)
            : base(id, name, age)
        {
            AppointmentDate = appointmentDate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Appointment Date: {AppointmentDate}");
        }
    }

    class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Doctor(int doctorId, string name, string specialization)
        {
            DoctorId = doctorId;
            Name = name;
            Specialization = specialization;
        }

        public void DisplayDoctor()
        {
            Console.WriteLine($"Doctor: {Name}");
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }

    class Bill : IPayable
    {
        public int BillId { get; set; }
        public double Amount { get; set; }

        public Bill(int billId, double amount)
        {
            BillId = billId;
            Amount = amount;
        }

        public void PayBill()
        {
            Console.WriteLine($"Bill {BillId} paid: Rs.{Amount}");
        }
    }
}


    

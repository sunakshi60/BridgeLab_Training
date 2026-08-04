using System;

namespace PracticeProblems
{
    interface Worker
    {
        void PerformDuties();
    }

    class RestaurantPerson
    {
        public  string Name;
        public int Id;

        public RestaurantPerson(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"ID : {Id}");
        }
    }

    class Chef : RestaurantPerson, Worker
    {
        public string SpecialDish;

        public Chef(string name, int id, string specialDish) : base(name, id)
        {
            SpecialDish = specialDish;
        }

        public void PerformDuties()
        {
            Console.WriteLine("Duty : Preparing delicious meals.");
            Console.WriteLine($"Special Dish : {SpecialDish}");
        }
    }

    class Waiter : RestaurantPerson, Worker
    {
        public string Section;

        public Waiter(string name, int id, string section) : base(name, id)
        {
            Section = section;
        }

        public void PerformDuties()
        {
            Console.WriteLine("Duty : Serving food to customers.");
            Console.WriteLine($"Section : {Section}");
        }
    }
}
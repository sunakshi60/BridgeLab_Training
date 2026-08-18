using System;

namespace PracticeProblems
{
    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Bird
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public Bird(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine(
                $"Name: {Name}, Species: {Species}");
        }
    }

    class Eagle : Bird, IFlyable
    {
        public Eagle(string name)
            : base(name, "Eagle")
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying high.");
        }
    }

    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name)
            : base(name, "Sparrow")
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }

    class Duck : Bird, ISwimmable
    {
        public Duck(string name)
            : base(name, "Duck")
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }

    class Penguin : Bird, ISwimmable
    {
        public Penguin(string name)
            : base(name, "Penguin")
        {
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }

    class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name)
            : base(name, "Seagull")
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }
}
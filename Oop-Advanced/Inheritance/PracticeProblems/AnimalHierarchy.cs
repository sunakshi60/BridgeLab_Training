using System;

namespace PracticeProblems
{
    class Animal
    {
        private string Name;
        private int Age;

        public Animal(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age} ");
        }
    }
    class Dog : Animal
    {
        public Dog(string name,int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
    
    class Cat : Animal
    {
        public Cat(string name,int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Bird: Animal
    {
        public Bird(string name,int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps.");
        }
    }
}
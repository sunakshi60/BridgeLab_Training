using System;

namespace OverView
{
    class Animal
    {
        public string Name;
        public void Eat() => Console.WriteLine($"{Name} is eating");
    }

    class Dog : Animal
    {
        public void Bark() => Console.WriteLine($"{Name} is barking");
    }
}
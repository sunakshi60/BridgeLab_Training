using System;

namespace BasicPractice
{
    class Animal2
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Dog2 : Animal2
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
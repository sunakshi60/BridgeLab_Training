using System;

namespace BasicPractice
{
    class Animal3
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Dog3 : Animal3
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

}
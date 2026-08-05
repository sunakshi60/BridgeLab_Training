using System;

namespace BasicPractice
{
    abstract class Animal5
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public abstract void Sound();
    }
    class Dog5 : Animal5
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }
    class Cat5 : Animal5
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
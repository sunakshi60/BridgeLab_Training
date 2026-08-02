using System;

namespace OverView
{
    //Method Overriding
    class AnimalPoly
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Dog : AnimalPoly
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat : AnimalPoly
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
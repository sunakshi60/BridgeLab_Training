using System;

namespace BasicPractice
{
    class Animal1
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog1 : Animal1
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }
    class Cat1 : Animal1
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
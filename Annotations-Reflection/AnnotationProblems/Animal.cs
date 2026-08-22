using System;

namespace AnnotationProblems
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof Woof!");
        }
    }
}
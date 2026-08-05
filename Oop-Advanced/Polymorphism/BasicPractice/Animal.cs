using System;

namespace BasicPractice
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
    }
}
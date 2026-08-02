using System;

namespace OverView
{
    //working of inheritance to see how one class inherit the properties and methods of another class.
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class DogInheritance : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
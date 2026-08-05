using System;

namespace BasicPractice
{
    class Animal4
    {
        public void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog4 : Animal4
    {
        public new void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
}
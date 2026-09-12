using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    public class Penguin : Bird, ISwimable, IRunnable
    {
        public Penguin(int birdId, string name, Gender gen) : base(birdId, name, gen)
        {
        }
        public void Swim()
        {
            Console.WriteLine(Name + " is swimming.");
        }
        public void Run()
        {
            Console.WriteLine(Name + " is running.");
        }
    }
}

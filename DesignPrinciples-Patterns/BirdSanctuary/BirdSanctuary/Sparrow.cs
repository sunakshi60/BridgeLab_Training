using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    public class Sparrow : Bird, IFlyable, IRunnable 
    { 
        public Sparrow(int birdId, string name, Gender gen) : base(birdId, name, gen) 
        { 
        }
        public void Fly() 
        {
            Console.WriteLine(Name + " is flying.");
        } 
        public void Run()
        { 
            Console.WriteLine(Name + " is running."); 
        } 
    }
}

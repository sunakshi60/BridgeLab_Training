using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    public class Duck : Bird, IFlyable, ISwimable, IRunnable 
    {
        public Duck(int birdId, string name, Gender gen) : base(birdId, name, gen) 
        { 
        } 
        public void Fly() 
        { 
            Console.WriteLine(Name + " is flying."); 
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

using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    public interface IRunnable 
    {
        void Run(); 
    }
    public interface ISwimable 
    { 
        void Swim(); 
    }
    public interface IFlyable
    { 
        void Fly(); 
    }
}

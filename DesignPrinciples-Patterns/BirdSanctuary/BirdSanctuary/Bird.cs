using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    public enum Gender
    {
        Male,Female
    }
    public class Bird
    {
        public int BirdId { get; set; }
        public string Name { get; set; }
        public Gender Gen { get; set; }

        public Bird(int birdId, string name, Gender gen) 
        { 
            BirdId = birdId;
            Name = name;
            Gen = gen; 
        }
        public override bool Equals(object obj)
        {
            if (obj is Bird other)
            {
                return BirdId == other.BirdId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return BirdId.GetHashCode();
        }
    }

    public class RemovalRecord 
    { 
        public Bird Bird { get; set; } 
        public string Reason { get; set; }
        public RemovalRecord(Bird bird, string reason) 
        {
            Bird = bird; 
            Reason = reason; 
        }
    }
}

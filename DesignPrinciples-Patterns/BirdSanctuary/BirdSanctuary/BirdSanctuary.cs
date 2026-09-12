using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSanctuary
{
    public class BirdSanctuary
    {
        private List<Bird> birds = new List<Bird>();
        private Dictionary<int, RemovalRecord> removalMap = new Dictionary<int, RemovalRecord>();

        public void AddBird(Bird bird)
        {
            foreach (Bird existingBird in birds)
            {
                if (existingBird.BirdId == bird.BirdId)
                {
                    Console.WriteLine($"Failed to add: Bird with ID {bird.BirdId} already exists.");
                    return;
                }
            }
            birds.Add(bird);
        }

        public void RemoveBird(int birdId,string reason)
        {
            Bird birdToRemove = null; 
            foreach (Bird bird in birds) 
            { 
                if (bird.BirdId == birdId) 
                { 
                    birdToRemove = bird; 
                    break; 
                } 
            }

            if (birdToRemove != null) 
            { 
                birds.Remove(birdToRemove); 
                removalMap[birdId] = new RemovalRecord(birdToRemove, reason);
            } 
            else 
            {
                Console.WriteLine("Bird not found."); 
            }
        }

        public void DisplayBirds()
        {
            Console.WriteLine("Birds in Sanctuary:");

            foreach (Bird bird in birds)
            {
                Console.WriteLine(
                    "ID: " + bird.BirdId +
                    ", Name: " + bird.Name +
                    ", Gender: " + bird.Gen
                );
            }
        }

        public void DisplayRemovedBirds() 
        { 
            Console.WriteLine("\nRemoved Bird Records:"); 
            foreach (KeyValuePair<int, RemovalRecord> item in removalMap) 
            { 
                RemovalRecord record = item.Value;
                Console.WriteLine("ID: " + record.Bird.BirdId + ", Name: " + record.Bird.Name + ", Reason: " + record.Reason); 
            } 
        }
    }
}

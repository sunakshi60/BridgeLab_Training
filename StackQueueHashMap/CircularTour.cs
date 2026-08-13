using System;
using System.Collections.Generic;

public class PetrolPump
{
    public int Petrol { get; set; }
    public int Distance { get; set; }

    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        Distance = distance;
    }
}

public class CircularTour
{
    public int FindStartingPoint(PetrolPump[] pumps)
    {
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < pumps.Length; i++)
        {
            queue.Enqueue(i);
        }

        int petrol = 0;
        while (queue.Count > 0)
        {
            int start = queue.Dequeue();
            petrol = 0;
            bool possible = true;

            for (int count = 0; count < pumps.Length; count++)
            {
                int current = (start + count) % pumps.Length;
                petrol += pumps[current].Petrol;
                petrol -= pumps[current].Distance;
                if (petrol < 0)
                {
                    possible = false;
                    break;
                }
            }
            if (possible)
            {
                return start;
            }
        }
        return -1;
    }
}
using System;
using System.Collections.Generic;

public class HospitalTriage
{
    public static void Solve()
    {
        PriorityQueue<string, int> patients = new PriorityQueue<string, int>();
        patients.Enqueue("John", -3);
        patients.Enqueue("Alice", -5);
        patients.Enqueue("Bob", -2);
        Console.WriteLine("Treatment Order:");
        while (patients.Count > 0)
        {
            string patient = patients.Dequeue();
            Console.WriteLine(patient);
        }
    }
}
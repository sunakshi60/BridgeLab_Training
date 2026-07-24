using System;

namespace Level2PracticeQues
{
    internal static class TravelDetailsCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("From City: ");
            string fromCity = Console.ReadLine();

            Console.Write("Via City: ");
            string viaCity = Console.ReadLine();

            Console.Write("Destination City: ");
            string toCity = Console.ReadLine();

            Console.Write("Distance From-To-Via (miles): ");
            double fromToVia = double.Parse(Console.ReadLine());

            Console.Write("Distance Via-To-Destination (miles): ");
            double viaToFinalCity = double.Parse(Console.ReadLine());

            Console.Write("Time Taken (hours): ");
            double timeTaken = double.Parse(Console.ReadLine());

            double totalDistance = fromToVia + viaToFinalCity;
            double averageSpeed = totalDistance / timeTaken;

            Console.WriteLine($"Traveler: {name}");
            Console.WriteLine($"Route: {fromCity} -> {viaCity} -> {toCity}");
            Console.WriteLine($"Total Distance: {totalDistance} miles");
            Console.WriteLine($"Average Speed: {averageSpeed:F2} miles/hour");
        }
    }
}
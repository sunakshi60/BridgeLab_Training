using System;

namespace PracticeQues
{
    internal static class EarthVolumeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Radius of Earth (in km): ");
            double radiusKm = double.Parse(Console.ReadLine());

            double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

            double radiusMiles = radiusKm / 1.6;
            double volumeMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

            Console.WriteLine(
                $"\nThe volume of Earth in cubic kilometers is {volumeKm:F2}" +
                $"\nThe volume of Earth in cubic miles is {volumeMiles:F2}"
            );
        }
    }
}
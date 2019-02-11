using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double mile = 1609;
            double timeInSeconds = (hours * 3600) + (minutes * 60) + seconds;
            double timeInHour = timeInSeconds / 3600.0;
            double speedMetersPerSeconds = distanceInMeters / timeInSeconds;
            double speedKmPerHour = (distanceInMeters / 1000.0) / timeInHour;
            double speedMilesPerHour = (distanceInMeters / mile) / timeInHour;
            Console.WriteLine($"{speedMetersPerSeconds:f6}");
            Console.WriteLine($"{speedKmPerHour:f6}");
            Console.WriteLine($"{speedMilesPerHour:f6}");
        }
    }
}

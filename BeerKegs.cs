using System;

namespace _12.BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestKegsVolume = 0;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= numberOfKegs; i++)
            {
                string modelOfKegs = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentKegsVolume = Math.PI * Math.Pow(radius, 2) * height;
                if (currentKegsVolume > biggestKegsVolume)
                {
                    biggestKegsVolume = currentKegsVolume;
                    biggestKeg = modelOfKegs;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}

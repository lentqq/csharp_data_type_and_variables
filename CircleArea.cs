using System;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double areea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{areea:f12}");
        }
    }
}

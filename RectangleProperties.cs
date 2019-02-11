using System;

namespace _12.RectangleProperies
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeterRectangle = (width + height) * 2;
            double areaRectangle = width * height;
            double diagonalRectangle = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            Console.WriteLine($"{perimeterRectangle}");
            Console.WriteLine($"{areaRectangle}");
            Console.WriteLine($"{diagonalRectangle}");
        }
    }
}

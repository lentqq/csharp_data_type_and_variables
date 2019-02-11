using System;

namespace _04.TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnits = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());
            switch (imperialUnits)
            {
                case "miles":
                    double kilometers = valueToConvert * 1.6;
                    Console.WriteLine($"{valueToConvert} miles = {kilometers:f2} kilometers");
                    break;
                case "inches":
                    double centimeters = valueToConvert * 2.54;
                    Console.WriteLine($"{valueToConvert} inches = {centimeters:f2} centimeters");
                    break;
                case "feet":
                    centimeters = valueToConvert * 30.0;
                    Console.WriteLine($"{valueToConvert} feet = {centimeters:f2} centimeters");
                    break;
                case "yards":
                    double meters = valueToConvert * 0.91;
                    Console.WriteLine($"{valueToConvert} yards = {meters:f2} meters");
                    break;
                case "gallons":
                    double liters = valueToConvert * 3.8;
                    Console.WriteLine($"{valueToConvert} gallons = {liters:f2} liters");
                    break;
            }
        }
    }
}

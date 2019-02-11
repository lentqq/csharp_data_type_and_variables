using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Convert.ToString(number,16).ToUpper()}");
            Console.WriteLine($"{Convert.ToString(number,2)}");
        }
    }
}

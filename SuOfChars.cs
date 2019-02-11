using System;

namespace _10.SumOfChars
{
    class SuOfChars
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                totalSum += symbol;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}

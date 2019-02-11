using System;

namespace _08.MakeAWord
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());
            char symbol = ' ';
            string word = string.Empty;
            for (int i = 1; i <= numbersOfLines; i++)
            {
                symbol = char.Parse(Console.ReadLine());
                word += symbol;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}

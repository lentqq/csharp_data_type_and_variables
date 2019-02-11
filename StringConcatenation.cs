using System;

namespace _11.StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string value = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string sentence = string.Empty;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string word = Console.ReadLine();
                if (value == "even" && i % 2 != 0)
                {
                    continue;
                }
                else if (value == "odd" && i % 2 == 0)
                {
                    continue;
                }
                sentence += $"{word}{delimeter}";             
            }        
            Console.WriteLine(sentence = sentence.Remove(sentence.Length -1));
        }
    }
}

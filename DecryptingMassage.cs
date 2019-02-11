using System;

namespace _13.DecryptingMessages
{
    class DecryptingMassage
    {
        static void Main(string[] args)
        {
            sbyte key = sbyte.Parse(Console.ReadLine());
            sbyte numberOfLne = sbyte.Parse(Console.ReadLine());
            string massage = string.Empty;
            char decryptSymbol = ' '; 
            for (int i = 1; i <= numberOfLne; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                decryptSymbol = (char)(symbol + key);
                massage += decryptSymbol;
            }
            Console.WriteLine(massage);
        }
    }
}

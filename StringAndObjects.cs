using System;

namespace _06.StringAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object result = firstWord +" "+ secondWord;
            Console.WriteLine(result);   
        }
    }
}

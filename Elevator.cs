using System;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeopel = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses =(int) Math.Ceiling((double)numberOfPeopel / capacity);
            Console.WriteLine(courses);
        }
    }
}

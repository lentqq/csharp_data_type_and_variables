using System;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)(minutes) * 60;
            ulong milliseconds = (ulong)(seconds * 1000);
            ulong microseconds = (milliseconds * 1000);
            ulong nanoseconds = (microseconds * 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days" +
                $" = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} milliseconds = " +
                $"{microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}

using System;

namespace _05.WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            try
            {
                long number = long.Parse(Console.ReadLine());
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Rainy");
            }
        }
    }
}

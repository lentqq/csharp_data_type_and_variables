using System;

namespace _06.CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {          
            string numeralTypeTheifsID = Console.ReadLine();
            byte countOfIDs = byte.Parse(Console.ReadLine());
            long equalToMaxValue = 0;
            switch (numeralTypeTheifsID)
            {
                case "sbyte":
                    equalToMaxValue = sbyte.MaxValue;
                    break;
                case "int":
                    equalToMaxValue = int.MaxValue;
                    break;
                case "long":
                    equalToMaxValue = long.MaxValue;
                    break;
            }
            long theifIDs = long.MinValue;
            for (int i = 0; i < countOfIDs; i++)
            {
                long closestID = long.Parse(Console.ReadLine());
                if (closestID > theifIDs && closestID <= equalToMaxValue)
                {
                    theifIDs = closestID;
                }
            }
            Console.WriteLine(theifIDs);
        }
    }
}

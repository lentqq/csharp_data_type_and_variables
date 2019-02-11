using System;

namespace _03.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int numbersPours = int.Parse(Console.ReadLine());
            int capacityOfTank = 255;
            int quantityWater = 0;
            int counter = 0;
            for (int i = 1; i <= numbersPours; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
  
                quantityWater += quantitiesOfWater;
                if (quantityWater >= capacityOfTank)
                { 
                    quantityWater -= quantitiesOfWater;
                    counter++;
                }
            }
            for (int i = 1; i <= counter; i++)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(quantityWater);
        }
    }
}

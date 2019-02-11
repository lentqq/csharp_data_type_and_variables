using System;

namespace _07.HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            long sbyteMaterials = long.Parse(Console.ReadLine());
            long intMaterials = long.Parse(Console.ReadLine());
            long totalPrice = 0;
            sbyte sbyteMaterial = 4;
            sbyte intMaterial = 10;

            if (sbyteMaterials >= 0 && sbyteMaterials <= sbyte.MaxValue)
            {
                totalPrice = sbyteMaterials * sbyteMaterial + intMaterials * intMaterial;
                Console.WriteLine(totalPrice);
            }
            else if (sbyteMaterials > sbyte.MaxValue && sbyteMaterials <= int.MaxValue)
            {
                totalPrice = sbyteMaterials * intMaterial + intMaterials * sbyteMaterial;
                Console.WriteLine(totalPrice);
            }
        }
    }
}

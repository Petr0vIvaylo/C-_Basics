using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.March._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePricePerKilo = double.Parse(Console.ReadLine());
            double fruitPricePerKilo = double.Parse(Console.ReadLine());
            int totalVegetableKillos = int.Parse(Console.ReadLine());
            int totalFruitKillos = int.Parse(Console.ReadLine());

            double eur = 1.94;

            double vegPrice = vegetablePricePerKilo * totalVegetableKillos;
            double fruitPrice = fruitPricePerKilo * totalFruitKillos;
            double totalCost = (vegPrice + fruitPrice) / eur;

            Console.WriteLine(totalCost);

        }
    }
}

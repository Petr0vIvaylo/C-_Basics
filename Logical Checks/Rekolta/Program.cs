using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqareArea = double.Parse(Console.ReadLine());
            double grapeSqareArea = double.Parse(Console.ReadLine());
            double littersRequare = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            double totalGrape = sqareArea * grapeSqareArea;
            double wine = (totalGrape * 0.4 / 2.5);

            if (wine >= littersRequare)
            {
                double wineWorkers = Math.Floor(wine - littersRequare);
                double winePerWorker = Math.Ceiling(wineWorkers / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n {1} liters left -> {2} liters per person."
                    , wine, wineWorkers, winePerWorker);
            }
            else if (littersRequare >= wine)
            {
                double lackOfWine = Math.Floor(littersRequare - wine);

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", lackOfWine);
            }

        }
    }
}

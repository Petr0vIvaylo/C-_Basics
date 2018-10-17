using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            double sizeOfLand = double.Parse(Console.ReadLine());
            double grapePerSquareMeter = double.Parse(Console.ReadLine());
            double wineNeedet = double.Parse(Console.ReadLine());
            double numberOfWorkers = double.Parse(Console.ReadLine());

            double totalGrapes = sizeOfLand * grapePerSquareMeter;
            double totalWine =  (totalGrapes /2.5) *0.4;

            if (wineNeedet <= totalWine)
            {
                double wineForWorkers =Math.Floor(totalWine - wineNeedet);
                double winePerWorker = Math.Ceiling(wineForWorkers / numberOfWorkers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n {1} liters left -> {2} liters per person.",totalWine,wineForWorkers, winePerWorker);
            }
            else
            {
                double wineForWorkers = Math.Floor(wineNeedet - totalWine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",wineForWorkers);
            }


        }
    }
}

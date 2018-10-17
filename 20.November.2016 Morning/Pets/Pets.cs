using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            double numberOfDays = double.Parse(Console.ReadLine());
            double foodLeftInKillos = double.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDayInGrams = double.Parse(Console.ReadLine());

            double dogFoodNeedet = numberOfDays * dogFoodPerDay;
            double catFoodNeedet = numberOfDays * catFoodPerDay;
            double turtleFoodNeedet = (numberOfDays * turtleFoodPerDayInGrams) / 1000;
            double totalFoodNeedet = dogFoodNeedet + catFoodNeedet + turtleFoodNeedet;

            if (totalFoodNeedet <= foodLeftInKillos)
            {
                double foodLeft = Math.Floor(foodLeftInKillos - totalFoodNeedet);
                Console.WriteLine("{0} kilos of food left.", foodLeft);
            }
            else
            {
                double foodLeft =Math.Ceiling(totalFoodNeedet - foodLeftInKillos);
                Console.WriteLine("{0} more kilos of food are needed.", foodLeft);
            }

        }
    }
}

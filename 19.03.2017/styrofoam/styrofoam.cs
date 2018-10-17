using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace styrofoam
{
    class styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double squareMeterHouse = double.Parse(Console.ReadLine());
            double numberOfWindows = double.Parse(Console.ReadLine());
            double numberOfStyrofoam = double.Parse(Console.ReadLine());
            double priceOfStyrofoam = double.Parse(Console.ReadLine());

            double sizeOfHouseWhitOutWindows = (squareMeterHouse - (numberOfWindows * 2.4))+0.1*(squareMeterHouse - (numberOfWindows * 2.4));
            double packetsNeedet = Math.Ceiling(sizeOfHouseWhitOutWindows / numberOfStyrofoam) * priceOfStyrofoam;

            if (budget > packetsNeedet)
            {
                Console.WriteLine("Spent: {0:F2}",packetsNeedet);
                Console.WriteLine("Left: {0:F2}",budget - packetsNeedet);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", Math.Abs(budget - packetsNeedet));
            }

        }
    }
}

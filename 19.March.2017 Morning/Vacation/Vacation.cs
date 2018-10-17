using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "a";
            double vacationCost = 0;
            string movingIn = "b";
            if (budget <= 1000)
            {
                 movingIn = "Camp";
                if (season == "Summer")
                {
                     location = "Alaska";
                     vacationCost = budget * 0.65;
                }
                else
	            {
                     location = "Morocco";
                     vacationCost = budget * 0.45;
	            }
            }
            else if (budget > 1000 && budget<= 3000)
            {
                 movingIn = "Hut";
                if (season == "Summer")
                {
                     location = "Alaska";
                     vacationCost = budget * 0.8;
                }
                else
                {
                     location = "Morocco";
                     vacationCost = budget * 0.6;
                }
            }

            else if (budget > 3000)
            {
                 movingIn = "Hotel";
                if (season == "Summer")
                {
                     location = "Alaska";
                     vacationCost = budget * 0.9;
                }
                else
                {
                     location = "Morocco";
                     vacationCost = budget * 0.9;
                }
            }

            Console.WriteLine("{0} - {1} - {2:F2}", location, movingIn,vacationCost);

        }
    }
}

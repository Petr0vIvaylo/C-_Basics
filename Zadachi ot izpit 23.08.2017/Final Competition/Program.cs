using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfDancers = double.Parse(Console.ReadLine());
            double numberOfPoints = double.Parse(Console.ReadLine());
           
            string season = Console.ReadLine();
            string location = Console.ReadLine();
            if (location == "Bulgaria")
            {

                double moneyPrice = numberOfPoints * numberOfDancers;
                if (season == "summer")
                {
                    double moneyPriceAfterTax = moneyPrice -( moneyPrice * 0.05);
                    double moneyAfterCharity = moneyPriceAfterTax * 0.75;
                    double moneyLeft = moneyPriceAfterTax - moneyAfterCharity;
                    double moneyPerDancer = moneyLeft / numberOfDancers;
                    Console.WriteLine("Charity - {0:F2}",      moneyAfterCharity);
                    Console.WriteLine("Money per dancer - {0:F2}", moneyPerDancer);
                }
                else if (season == "winter")
	            {
		            double moneyPriceAfterTax = moneyPrice -( moneyPrice * 0.08);
                    double moneyAfterCharity = moneyPriceAfterTax * 0.75;
                    double moneyLeft = moneyPriceAfterTax - moneyAfterCharity;
                    double moneyPerDancer = moneyLeft / numberOfDancers;
                    Console.WriteLine("Charity - {0:F2}", moneyAfterCharity);
                    Console.WriteLine("Money per dancer - {0:F2}", moneyPerDancer);
	            }
            }
            else if (location == "Abroad")
            {
                double moneyPrice = (numberOfPoints * numberOfDancers)+ (numberOfPoints * numberOfDancers)/2;
                if (season == "summer")
                {
                    double moneyPriceAfterTax = moneyPrice - (moneyPrice * 0.1);
                    double moneyAfterCharity = moneyPriceAfterTax * 0.75;
                    double moneyLeft = moneyPriceAfterTax - moneyAfterCharity;
                    double moneyPerDancer = moneyLeft / numberOfDancers;
                    Console.WriteLine("Charity - {0:F2}", moneyAfterCharity);
                    Console.WriteLine("Money per dancer - {0:F2}", moneyPerDancer);
                }
                else if (season == "winter")
                {
                    double moneyPriceAfterTax = moneyPrice - (moneyPrice * 0.15);
                    double moneyAfterCharity = moneyPriceAfterTax * 0.75;
                    double moneyLeft = moneyPriceAfterTax - moneyAfterCharity;
                    double moneyPerDancer = moneyLeft / numberOfDancers;
                    Console.WriteLine("Charity - {0:F2}", moneyAfterCharity);
                    Console.WriteLine("Money per dancer - {0:F2}", moneyPerDancer);
                }
            }


        }
    }
}

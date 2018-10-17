using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double milesPerMonth = double.Parse(Console.ReadLine());
            double pricePerMile = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (milesPerMonth <= 5000)
                {
                    pricePerMile = 0.75;
                }
                else if (milesPerMonth > 500 && milesPerMonth <=10000)
                {
                    pricePerMile = 0.95;
                }
                else if (milesPerMonth >10000 && milesPerMonth<= 20000)
                {
                    pricePerMile = 1.45;
                }
            }
            else if (season == "Summer")
            {
                if (milesPerMonth <= 5000)
                {
                    pricePerMile = 0.9;
                }
                else if (milesPerMonth > 500 && milesPerMonth <= 10000)
                {
                    pricePerMile = 1.1;
                }
                else if (milesPerMonth > 10000 && milesPerMonth <= 20000)
                {
                    pricePerMile = 1.45;
                }
            }
            else if (season == "Winter")
            {
                if (milesPerMonth <= 5000)
                {
                    pricePerMile = 1.05;
                }
                else if (milesPerMonth > 500 && milesPerMonth <= 10000)
                {
                    pricePerMile = 1.25;
                }
                else if (milesPerMonth > 10000 && milesPerMonth <= 20000)
                {
                    pricePerMile = 1.45;
                }
            }
            double taxes = (pricePerMile * milesPerMonth) ;
            double moneyAfterTaxes = 4 * (pricePerMile * milesPerMonth) - 4*(pricePerMile * milesPerMonth)*0.1;

            Console.WriteLine("{0:F2}",moneyAfterTaxes);



        }
    }
}

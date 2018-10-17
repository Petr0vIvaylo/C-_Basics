using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentACar
{
    class RentACar
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season =(Console.ReadLine());

            string car = "";
            string clasS = "";
            double costOfCar = 0;


            if (budget <= 100)
            {
                clasS = "Economy class";
                if (season == "Summer")
                {
                    costOfCar = budget * 0.35;
                    car = "Cabrio";
                }
                else if (season == "Winter")
                {
                    costOfCar = budget * 0.65;
                    car = "Jeep";
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                clasS = "Compact class";
                if (season == "Summer")
                {
                    costOfCar = budget * 0.45;
                    car = "Cabrio";
                }
                else if (season == "Winter")
                {
                    costOfCar = budget * 0.80;
                    car = "Jeep";
                }
            }
            else if (budget > 500)
            {
                clasS = "Luxury class";
                if (season == "Summer")
                {
                    costOfCar = budget * 0.9;
                    car = "Jeep";
                }
                else if (season == "Winter")
                {
                    costOfCar = budget * 0.90;
                    car = "Jeep";
                }
            }

            Console.WriteLine(clasS);
            Console.WriteLine(car + " - {0:F2}", costOfCar);

        }
    }
}

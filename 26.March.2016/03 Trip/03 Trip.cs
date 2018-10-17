using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    double budgetleft = (budget * 30) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2} ", budgetleft);
                }
                else if (season == "winter")
                {
                    double budgetleft = (budget * 70) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2} ", budgetleft);
                }

            }
            else if (budget <= 1000 && budget > 100)
            {
                if (season == "summer")
                {
                    double budgetleft = (budget * 40) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2} ", budgetleft);
                }
                else if (season == "winter")
                {
                    double budgetleft = (budget * 80) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2} ", budgetleft);
                }
            }
            else if (budget >1000)
            {
                if (season == "summer")
                {
                    double budgetleft = (budget * 90) / 100;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2} ", budgetleft);
                }
                else if (season == "winter")
                {
                    double budgetleft = (budget * 90) / 100;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:F2} ", budgetleft);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19._03._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeterLoze = double.Parse(Console.ReadLine());
            double kilosFromLand = double.Parse(Console.ReadLine());
            double scrap = double.Parse(Console.ReadLine());

            double grapes = (squareMeterLoze * kilosFromLand) -  scrap;
            double grapesForSale = grapes * 0.55*1.5;
            double forRakia = (grapes * 0.45)/7.5;
            double income = forRakia * 9.8;

            Console.WriteLine("{0:F2}",income);
            Console.WriteLine("{0:F2}", grapesForSale);
        }
    }
}

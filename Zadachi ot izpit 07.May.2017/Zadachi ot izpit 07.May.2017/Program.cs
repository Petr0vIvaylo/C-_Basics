using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadachi_ot_izpit_07.May._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskeyAmount = double.Parse(Console.ReadLine());


            double rakiaPrice = (whiskeyPrice / 2) ;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double rakiaSum = rakiaPrice * rakia;
            double beerSum = beerPrice * beer;
            double wineSum = winePrice * wine;
            double whyskeySum = whiskeyPrice * whiskeyAmount;

            Console.WriteLine("{0:F2}", rakiaSum + beerSum + wineSum + whyskeySum);
        }
    }
}

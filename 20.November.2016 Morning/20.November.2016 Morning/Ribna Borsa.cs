using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.November._2016_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForSkumriaKilo = double.Parse(Console.ReadLine());
            double priceForCacaKilo = double.Parse(Console.ReadLine());
            double palamudKilo = double.Parse(Console.ReadLine());
            double safridKilo = double.Parse(Console.ReadLine());
            double muselsKilo = double.Parse(Console.ReadLine());

            double palamudPrice = priceForSkumriaKilo + priceForSkumriaKilo * 0.6;
            double safridPrice = priceForCacaKilo + priceForCacaKilo * 0.8;
            double muselsPrice = 7.5;

            double totalSum = (palamudPrice * palamudKilo) + (safridPrice * safridKilo) + (muselsKilo * muselsPrice);
            Console.WriteLine("{0:F2}", totalSum);


        }
    }
}

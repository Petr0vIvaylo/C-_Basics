using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();

            if (kilometers<20)
            {
                if (tariff == "day")
                {
                    double price = 0.7 + (kilometers * 0.79);
                    Console.WriteLine("{0:F2}", price);
                }
                else if (tariff == "night")
                {
                    double price = 0.7 + (kilometers * 0.9);
                    Console.WriteLine("{0:F2}", price);
                }
                
            }

            if (kilometers>=20  && kilometers < 100)
            {

                if (tariff == "day")
                {
                    double price = kilometers * 0.09;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (tariff == "night")
                {
                    double price = kilometers * 0.09;
                    Console.WriteLine("{0:F2}", price);
                }
                
            }

            if (kilometers>=100 )
            {
                if ( tariff == "day")
                {
                    double price = kilometers * 0.06;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (tariff == "night")
                {
                    double price = kilometers * 0.06;
                    Console.WriteLine("{0:F2}", price);
                }

                
            }
        }
    }
}

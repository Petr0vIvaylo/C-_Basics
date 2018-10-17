using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if ((dayOfWeek != "monday" && dayOfWeek != "tuesday" && dayOfWeek != "wednesday" 
                && dayOfWeek != "thursday" && dayOfWeek != "friday" && dayOfWeek != "saturday"
                && dayOfWeek != "sunday"))
            {

                Console.WriteLine("error");
                return;
            }
            else if ((product != "banana" && product != "apple" && product != "orange" &&
                product != "grapefruit" && product != "kiwi" && product != "pineapple"
                && product != "grapes"))
            {
                Console.WriteLine("error");
                return;
            }

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday"
                || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                if (product == "banana")
                {
                    double price = 2.50 * quantity;
                    Console.WriteLine("{0:F2}" ,price);
                }
                else if (product == "apple")
                {
                    double price = 1.20 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "orange")
                {
                    double price = 0.85 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "grapefruit")
                {
                    double price = 1.45 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "kiwi")
                {
                    double price = 2.70 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "pineapple")
                {
                    double price = 5.50 * quantity;
                   Console.WriteLine("{0:F2}", price);
                }
                else if (product == "grapes")
                {
                    double price = 3.85 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
            }

            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                if (product == "banana")
                {
                    double price = 2.70 * quantity;
                   Console.WriteLine("{0:F2}", price);
                }
                else if (product == "apple")
                {
                    double price = 1.25 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "orange")
                {
                    double price = 0.90 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "grapefruit")
                {
                    double price = 1.60 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "kiwi")
                {
                    double price = 3.00 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "pineapple")
                {
                    double price = 5.60 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
                else if (product == "grapes")
                {
                    double price = 4.20 * quantity;
                    Console.WriteLine("{0:F2}", price);
                }
            }
           


        }
    }
}

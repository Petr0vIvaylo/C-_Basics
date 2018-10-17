using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Commision
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            if (town != "varna" && town != "sofia" && town != "plovdiv")
            {
                Console.WriteLine("error");
                return;
            }
            else if (sales < 0)
            {
                Console.WriteLine("error");
                return;
            }

            if (town == "sofia")
            {
                if (0 <= sales && sales <=500)
                {
                    double commision = sales *0.05;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (500 < sales && sales <= 1000)
                {
                    double commision = sales * 0.07;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    double commision = sales * 0.08;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (sales > 10000)
                {
                    double commision = sales * 0.12;
                    Console.WriteLine("{0:F2}", commision);
                }
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    double commision = sales * 0.045;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (500 < sales && sales <= 1000)
                {
                    double commision = sales * 0.075;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    double commision = sales * 0.1;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (sales > 10000)
                {
                    double commision = sales * 0.13;
                    Console.WriteLine("{0:F2}", commision);
                }
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    double commision = sales * 0.055;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (500 < sales && sales <= 1000)
                {
                    double commision = sales * 0.08;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (1000 < sales && sales <= 10000)
                {
                    double commision = sales * 0.12;
                    Console.WriteLine("{0:F2}", commision);
                }
                else if (sales > 10000)
                {
                    double commision = sales * 0.145;
                    Console.WriteLine("{0:F2}", commision);
                }
            }
        }
    }
}

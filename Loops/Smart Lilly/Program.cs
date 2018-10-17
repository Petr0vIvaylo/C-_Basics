using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int lillyYears = int.Parse(Console.ReadLine());
            double loundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double toys = 0;
            double savings = 0;
            double sumSavings = 0;

            for (int i = 1; i <= lillyYears; i++)
            {
                if (i % 2 == 0)
                {

                    sumSavings = sumSavings + savings + 10 ;
                    savings += 10;
                }
                else
                {
                    toys++;
                }
            }
            double moneyFromToys = toys * toyPrice;
            double totalSavings = (moneyFromToys + sumSavings)- (lillyYears/2);
            if (totalSavings > loundryPrice)
            {
                Console.WriteLine("Yes! {0:F2}", totalSavings - loundryPrice);
            }
            else
            {
                Console.WriteLine("No! {0:F2}" , loundryPrice - totalSavings);
            }
        }
    }
}

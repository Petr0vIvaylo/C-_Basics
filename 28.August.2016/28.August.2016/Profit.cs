using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.August._2016
{
    class Profit
    {
        static void Main(string[] args)
        {
            double workingDaysInMonth = double.Parse(Console.ReadLine());
            double earningsPerDay = double.Parse(Console.ReadLine());
            double dollarValue = double.Parse(Console.ReadLine());

            double monthlySelary = workingDaysInMonth * earningsPerDay;
            double yearSelary = monthlySelary * 12 + monthlySelary * 2.5;
            double earningsAfterTaxes = (yearSelary - yearSelary * 0.25) * dollarValue;
            double earningPerDayInLeva = earningsAfterTaxes / 365;

            Console.WriteLine("{0:F2}", earningPerDayInLeva);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadachi_ot_25.June._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForCampany = int.Parse(Console.ReadLine());
            int CooksNumber = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int wafelsCount = int.Parse(Console.ReadLine());
            int pancakesNumber = int.Parse(Console.ReadLine());

            int cake = 45 * cakeCount;
            double wafels = 5.8 * wafelsCount;
            double pancakes = 3.2 * pancakesNumber;

            double totalSumFromCooks = (cake + wafels + pancakes) * CooksNumber;
            double sumFromAllDays = totalSumFromCooks * daysForCampany;
            double moneyAfterExpencies = sumFromAllDays - (0.125 * sumFromAllDays);

            Console.WriteLine("{0:F2}", moneyAfterExpencies);

        }
    }
}

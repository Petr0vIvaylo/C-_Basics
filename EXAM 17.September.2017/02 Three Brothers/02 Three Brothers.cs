using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());


            double totalTimeForCleaning = 1 / (1 / firstTime + 1 / secondTime + 1 / thirdTime) 
                + (1 / (1 / firstTime + 1 / secondTime + 1 / thirdTime))*0.15;

            if (totalTimeForCleaning <= fishingTime)
            {
                Console.WriteLine("Cleaning time: {0:F2}" , totalTimeForCleaning);
                double timeDiff = Math.Floor(fishingTime - totalTimeForCleaning);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours." , timeDiff);
            }
            else
            {
                Console.WriteLine("Cleaning time: {0:F2}", totalTimeForCleaning);
                double timeDiff = Math.Abs(fishingTime - totalTimeForCleaning);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(timeDiff));
            }

        }
    }
}

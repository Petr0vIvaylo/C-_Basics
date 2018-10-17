using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glasses
{
    class Glasses
    {
        static void Main(string[] args)
        {
            int numberOfGlassesPerDay = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            double totalWorkingHours = numberOfWorkers * numberOfWorkingDays * 8;
            double glassesProduced = Math.Floor(totalWorkingHours / 5);

            if (glassesProduced < numberOfGlassesPerDay )
            {
                double loses = Math.Abs(glassesProduced - numberOfGlassesPerDay) * 4.2;
                Console.WriteLine("Losses: {0:F2}", loses);
            }
            else
            {
                double extraMoney = Math.Abs(glassesProduced - numberOfGlassesPerDay) * 4.2;

                Console.WriteLine("{0:F2} extra money",extraMoney);
            }


        }
    }
}

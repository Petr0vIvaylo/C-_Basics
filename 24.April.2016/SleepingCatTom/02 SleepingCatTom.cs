using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            double workingDays = 365 - daysOff;
            double totalPlayTime = (workingDays * 63) + (daysOff * 127);

            if (totalPlayTime <30000)
            {
                double timeLeft = 30000 - totalPlayTime;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",Math.Floor(timeLeft/60), Math.Floor(timeLeft%60));
            }
            else
            {
                double timeLeft = Math.Abs(30000 - totalPlayTime);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play"
                    , Math.Floor(timeLeft / 60), Math.Floor(timeLeft % 60));
            }
        }
    }
}

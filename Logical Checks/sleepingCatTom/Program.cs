using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workDays = 365 - daysOff;
            int whenWork = workDays * 63;
            int whenRest = daysOff * 127;
            int totalHoursForPlay = whenWork + whenRest;
            int hoursLeftForPlay = 30000 - (whenWork + whenRest);

           
            if (totalHoursForPlay < 30000 )
            {

                Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play",

                   hoursLeftForPlay / 60, hoursLeftForPlay % 60);
            }
            else
            {
               int overPlay = totalHoursForPlay - 30000;

                Console.WriteLine("Tom will run away \n {0} hours and {1} minutes more for play",
                  overPlay /60 ,overPlay% 60 ) ;

            }
        }
    }
}

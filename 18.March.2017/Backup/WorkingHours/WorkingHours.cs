using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingHours
{
    class WorkingHours
    {
        static void Main(string[] args)
        {
            double requieredHours = double.Parse(Console.ReadLine());
            double numberOfWorkers = double.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            double hoursOfWork = numberOfWorkers * workingDays * 8;


            if (hoursOfWork > requieredHours)
            {
                double hoursLeft = hoursOfWork - requieredHours;
                Console.WriteLine(hoursLeft + " hours left");
            }
            else
	        {
                double hoursLeft = Math.Abs(hoursOfWork - requieredHours);
                double penalties = hoursLeft * workingDays;
                Console.WriteLine(hoursLeft +" overtime");
                Console.WriteLine( "Penalties: " +penalties);
	        }

        }
    }
}

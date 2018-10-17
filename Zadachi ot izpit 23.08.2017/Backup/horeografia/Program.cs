using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace horeografia
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfSteps = double.Parse(Console.ReadLine());
            double numberOfDancers = double.Parse(Console.ReadLine());
            double daysForLearn = double.Parse(Console.ReadLine());

            double stepsPerDayPercent = Math.Ceiling((numberOfSteps / daysForLearn) / numberOfSteps * 100);
            
           

           

            if (stepsPerDayPercent <= 13)
            {
                double percentPerDancer = Math.Round((stepsPerDayPercent / numberOfDancers),3 , MidpointRounding.AwayFromZero);
                Console.WriteLine("Yes, they will succeed in that goal! {0:F2}%." ,percentPerDancer );
            }
            else
            {

                double percentPerDancer = Math.Round((stepsPerDayPercent / numberOfDancers),3 ,MidpointRounding.AwayFromZero);
                Console.WriteLine("No, They will not succeed in that goal! Required {0:F2}% steps to be learned per day.", percentPerDancer);
            }


        }
    }
}

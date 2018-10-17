using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniorbycicles = int.Parse(Console.ReadLine());
            int seniorbycicles = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double juniorTax = 0;
            double seniorTax = 0;
            double tax = 0;
            double afterTax = 0;

            if (track == "trail")
            {
                juniorTax = 5.5;
                seniorTax = 7;
            }
            else if (track == "cross-country")
            {
                juniorTax = 8;
                seniorTax = 9.5;
            }
            else if (track == "downhill")
            {
                juniorTax = 12.25;
                seniorTax =13.75;
            }
            else if (track == "road")
            {
                juniorTax = 20;
                seniorTax = 21.5;
            }

            if (track == "cross-country" && juniorbycicles + seniorbycicles >=50)
            {
                tax = juniorbycicles * juniorTax + seniorbycicles * seniorTax;
                afterTax = tax - tax * 0.25;
                Console.WriteLine("{0:F2}", afterTax);
            }
            else
            {
                tax = juniorbycicles * juniorTax + seniorbycicles * seniorTax;
                afterTax = tax - tax * 0.05;
                Console.WriteLine("{0:F2}", afterTax);
            }


        }
    }
}

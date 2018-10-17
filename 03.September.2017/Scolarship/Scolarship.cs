using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship
{
    class Scolarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double MRZ = double.Parse(Console.ReadLine());

            if (income <= MRZ && averageSuccess > 4.5)
            {
                double socialnaStipendiq = Math.Floor(MRZ * 0.35);
                Console.WriteLine("You get a Social scholarship {0} BGN", socialnaStipendiq);
                if (averageSuccess >=5.5)
                {
                    double stipendiqZaUspeh = Math.Floor(averageSuccess * 25);

                    if (stipendiqZaUspeh >=socialnaStipendiq)
                    {
                        Console.WriteLine("You get a scholarship for excellent results {0} BGN",stipendiqZaUspeh);
                    }
                    
                }

            }
            else if (income > MRZ && averageSuccess >= 5.5)
            {
                double stipendiqZaUspeh = Math.Floor(averageSuccess * 25);
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", (stipendiqZaUspeh));
            }



            else if (income > MRZ && averageSuccess < 5.5  || income < MRZ && averageSuccess < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            


        }
    }
}

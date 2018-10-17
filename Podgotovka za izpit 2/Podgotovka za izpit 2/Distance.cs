using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_za_izpit_2
{
    class Distance
    {
        static void Main(string[] args)
        {
            double kmh = double.Parse(Console.ReadLine());
            double time1 = double.Parse(Console.ReadLine());
            double time2 = double.Parse(Console.ReadLine());
            double time3 = double.Parse(Console.ReadLine());

            double firstTime = kmh * (time1 / 60);
            double secondTime = (kmh + (kmh * 0.1))*(time2 / 60);
            double thirdTime = (kmh + (kmh * 0.1) - ((kmh + (kmh * 0.1)) * 0.05)) * (time3 / 60);
            double totalTime = firstTime + secondTime + thirdTime;

            
            Console.WriteLine("{0:f2}",totalTime);


        }
    }
}

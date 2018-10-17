using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.December._2016
{
    class Distance
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());
            decimal firstSpeed = decimal.Parse(Console.ReadLine());
            decimal secondSpeed = decimal.Parse(Console.ReadLine());
            decimal thurdSpeed = decimal.Parse(Console.ReadLine());

            decimal speedTenPercent = speed * 0.1m;
            decimal speedFivePercent = (speed + speedTenPercent) * 0.05m;
            decimal V0 = speed  * firstSpeed / 60;
            decimal speedUp = (speed + speedTenPercent) * secondSpeed / 60;
            decimal speedDown = ((speed + speedTenPercent) - speedFivePercent) * thurdSpeed / 60;

            decimal speedSum = V0 + speedUp + speedDown;
           
            Console.WriteLine("{0:F2}" , speedSum);
        }
    }
}

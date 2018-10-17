using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusPoints
{
    class bonusPoints
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 100)
            {
                bonusPoints = points * 0.2;
                
            }
            else if (points > 1000)
            {
                bonusPoints = points * 0.1;
            }
            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);

        }   
    }
}

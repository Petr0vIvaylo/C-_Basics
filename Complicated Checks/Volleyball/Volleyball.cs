using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());



            if (year == "leap")
            {
                double weekends = (48 - h) * (3.0 / 4.0);
                double holyDayPlay = p * (2.0 / 3.0);
                double totalPlays = Math.Truncate((weekends + h + holyDayPlay) * 1.15);
                Console.WriteLine("{0}", totalPlays);
            }
            else
            {
                double weekends = (48 - h) * 3.0 / 4.0;
                double holyDayPlay = p * 2.0 / 3.0;
                double totalPlays = Math.Truncate((weekends + h + holyDayPlay));
                Console.WriteLine("{0}", totalPlays);
            }

        }
    }
}

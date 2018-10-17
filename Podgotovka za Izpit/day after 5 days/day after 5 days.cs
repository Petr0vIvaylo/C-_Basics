using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_after_5_days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int daysInMonth = 31;

            if (month == 2 || month == 02)
            {
                daysInMonth = 28;
            }
            else if (month == 4 || month == 04 || month == 06 || month == 6 ||
                        month == 09 || month == 9 || month == 11)
            {
                daysInMonth = 30;
            }
            //else if (month == 01 || month == 1 || month == 03 || month == 3 ||
            //         month == 05 || month == 5 || month == 07 || month ==7 || 
            //         month ==08 || month == 8 || month ==12 )
            //{
            //    daysInMonth = 31;
            //}

            day += 5;
            
            if (day > daysInMonth)
            {
                day -= daysInMonth;
                month++;
                if (month > 12)
                {
                    month = 1;
                }
                
            }
            Console.WriteLine("{0}.{1:D2}",day,month);


        }
    }
}

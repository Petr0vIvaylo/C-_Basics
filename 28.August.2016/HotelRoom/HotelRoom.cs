using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numberOfnights = double.Parse(Console.ReadLine());

            double studioPrce = 0;
            double apartment = 0;


            if (month == "May" || month == "October")
            {
                studioPrce = 50;
                apartment = 65;
                if (numberOfnights >7 && numberOfnights < 14)
                {
                    studioPrce = 50 - 50 * 0.05;
                }
                else if (numberOfnights > 14)
                {
                    studioPrce = 50 - 50 * 0.3;
                    apartment = 65 - 65 * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrce = 75.2;
                apartment = 68.7;
                if (numberOfnights > 14)
                {
                    studioPrce = 75.2 - 75.2 * 0.2;
                    apartment = 68.7 - 68.7 * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrce = 76;
                apartment = 77;
                if (numberOfnights > 14)
                {
                    apartment = 77 - 77 *0.1;
                }
            }

            double studioCost = studioPrce * numberOfnights;
            double apartmentCost = apartment * numberOfnights;

            
            Console.WriteLine("Apartment: {0:F2} lv.", apartmentCost);
            Console.WriteLine("Studio: {0:F2} lv.", studioCost);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop
{
    class FlowersShop
    {
        static void Main(string[] args)
        {
            int numberOfhrizantemi = int.Parse(Console.ReadLine());
            int numberOfRozes = int.Parse(Console.ReadLine());
            int numberOfLaleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string hollyday = Console.ReadLine().ToUpper();

            double hrizantemi = 0;
            double rozes = 0;
            double laleta = 0;



            if (season == "Spring" || season == "Summer")
            {
                hrizantemi = 2;
                rozes = 4.1;
                laleta = 2.5;
                
            }
            else
            {
                hrizantemi = 3.75;
                rozes = 4.5;
                laleta = 4.15;
            }

            double fwolewrsSum = (numberOfhrizantemi * hrizantemi) + (numberOfRozes * rozes) +
                (numberOfLaleta * laleta);
            if (hollyday == "Y")
            {
                fwolewrsSum = ((numberOfhrizantemi * hrizantemi) + (numberOfRozes * rozes) +
                (numberOfLaleta * laleta))+ ((numberOfhrizantemi * hrizantemi) + (numberOfRozes * rozes) +
                (numberOfLaleta * laleta)) * 0.15;
            }
            else
            {
                fwolewrsSum = (numberOfhrizantemi * hrizantemi) + (numberOfRozes * rozes) +
                (numberOfLaleta * laleta);
            }

            if (season == "Spring" && numberOfLaleta >=7 )
            {
                fwolewrsSum = fwolewrsSum - (fwolewrsSum * 0.05);
            }
            else if (season == "Winter" && numberOfRozes >= 10)
            {
                fwolewrsSum = fwolewrsSum - (fwolewrsSum * 0.1);
            }

            if (numberOfhrizantemi + numberOfRozes + numberOfLaleta >= 20)
            {
                fwolewrsSum = fwolewrsSum - (fwolewrsSum * 0.2);
            }

            Console.WriteLine("{0:F2}", fwolewrsSum+2);

        }
    }
}

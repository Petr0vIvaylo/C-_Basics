using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double fanCount = double.Parse(Console.ReadLine());

            double fansInSectorA=0;
            double fansInSectorB = 0;
            double fansInSectorC = 0;
            double fansInSectorD = 0;
            

            for (int i = 0; i < fanCount; i++)
            {
                string sectorPosition = Console.ReadLine().ToUpper();
                if (sectorPosition == "A")
                {
                    fansInSectorA += 1;
                }
                else if (sectorPosition == "B")
                {
                    fansInSectorB += 1;
                }
                else if (sectorPosition == "V")
                {
                    fansInSectorC += 1;
                }
                else if (sectorPosition == "G")
                {
                    fansInSectorD += 1;
                }

            }
            
            double fanNumberA = (fansInSectorA / fanCount) * 100;
            double fanNumberB = (fansInSectorB / fanCount) * 100;
            double fanNumberC = (fansInSectorC / fanCount) * 100;
            double fanNumberD = (fansInSectorD / fanCount) * 100;
            double stadiumCapacityOcupayed = (fanCount / stadiumCapacity) * 100;
            Console.WriteLine("{0:F2}%", fanNumberA);
            Console.WriteLine("{0:F2}%", fanNumberB);
            Console.WriteLine("{0:F2}%", fanNumberC);
            Console.WriteLine("{0:F2}%", fanNumberD);
            Console.WriteLine("{0:F2}%", stadiumCapacityOcupayed);


        }
    }
}

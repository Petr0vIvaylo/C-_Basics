using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            double numberOfCargo = int.Parse(Console.ReadLine());
            double cargoSum = 0;

            double massOfCargo3 = 0;
            double massOfCargo11 = 0;
            double massOfCargo12 = 0;

            double cargoThreeTons = 0;
            double cargoElevenTons = 0;
            double cargoTwelveTons = 0;

            for (int i = 0; i < numberOfCargo; i++)
            {
                double massOfCargo = double.Parse(Console.ReadLine());
                cargoSum += massOfCargo;

                if (massOfCargo <= 3 && massOfCargo >= 0)
                {
                     cargoThreeTons += 200 * massOfCargo;
                    massOfCargo3 += massOfCargo;
                }
                else if (massOfCargo >= 4 && massOfCargo <= 11)
                {
                     cargoElevenTons += 175 * massOfCargo;
                    massOfCargo11 += massOfCargo;
                }
                else if ( massOfCargo > 12)
                {
                     cargoTwelveTons += 120 * massOfCargo;
                    massOfCargo12 += massOfCargo;
                }
            }

            double averageTons = (cargoThreeTons + cargoElevenTons + cargoTwelveTons) / cargoSum;
            double bus = (massOfCargo3 / cargoSum) * 100;
            double truck = (massOfCargo11 / cargoSum) * 100;
            double train = (massOfCargo12 / cargoSum) * 100;

            Console.WriteLine("{0:F2}", averageTons);
            Console.WriteLine("{0:F2}%", bus);
            Console.WriteLine("{0:F2}%", truck);
            Console.WriteLine("{0:F2}%", train);
            

        }
    }
}

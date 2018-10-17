using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            double numberOfGroups = double.Parse(Console.ReadLine());

            double car = 0;
            double bus = 0;
            double smallBus = 0;
            double bigBus = 0;
            double train = 0;

            double totalAmountOfPeople = 0;


            for (int i = 0; i < numberOfGroups; i++)
            {
                double numberOfKids = double.Parse(Console.ReadLine());

                if (numberOfKids <= 5)
                {
                    car += numberOfKids;
                    totalAmountOfPeople += numberOfKids;
                }
                else if (numberOfKids >= 6 && numberOfKids <= 12 )
                {
                    bus += numberOfKids;
                    totalAmountOfPeople += numberOfKids;
                }
                else if (numberOfKids >= 13 && numberOfKids <= 25)
                {
                    smallBus += numberOfKids;
                    totalAmountOfPeople += numberOfKids;
                }
                else if (numberOfKids >= 26 && numberOfKids <= 40)
                {
                    bigBus += numberOfKids;
                    totalAmountOfPeople += numberOfKids;
                }
                else if (numberOfKids >= 41 )
                {
                    train += numberOfKids;
                    totalAmountOfPeople += numberOfKids;
                }

            }

            double carTravelers = (car / totalAmountOfPeople) * 100;
            double busTravelers = (bus / totalAmountOfPeople) * 100;
            double smallBusTravelers = (smallBus / totalAmountOfPeople) * 100;
            double bigBusTravelers = (bigBus / totalAmountOfPeople) * 100;
            double trainTravelers = (train / totalAmountOfPeople) * 100;

            Console.WriteLine("{0:F2}%", carTravelers);
            Console.WriteLine("{0:F2}%", busTravelers);
            Console.WriteLine("{0:F2}%", smallBusTravelers);
            Console.WriteLine("{0:F2}%", bigBusTravelers);
            Console.WriteLine("{0:F2}%", trainTravelers);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.November._2016___Evening
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double areaOfSmallestRoom = double.Parse(Console.ReadLine());
            double areaOfKitchen = double.Parse(Console.ReadLine());
            double pricePerSqareMeter = double.Parse(Console.ReadLine());

            double bathRoom = areaOfSmallestRoom / 2;
            double secondRoom = areaOfSmallestRoom + areaOfSmallestRoom * 0.1;
            double thirdRoom = secondRoom + secondRoom * 0.1;
            double totalAreaOfApartment = areaOfSmallestRoom + areaOfKitchen + bathRoom +
                secondRoom + thirdRoom;

            double apartmentPlusKoridor = totalAreaOfApartment + totalAreaOfApartment * 0.05;
            double price = apartmentPlusKoridor * pricePerSqareMeter;
            Console.WriteLine("{0:F2}", price);
        }
    }
}

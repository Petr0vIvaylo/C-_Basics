using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18.March._2017
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            double heightOfHouse = double.Parse(Console.ReadLine());

            double sidesOfHouse = sideLength * (sideLength / 2) * 2;
            double backSide = (sideLength / 2) * (sideLength / 2) + (sideLength / 2 * (heightOfHouse - sideLength / 2)) / 2;
            double frontSide = backSide - (sideLength / 5) * (sideLength / 5);
            double totalSurfaceOfHouse = sidesOfHouse + backSide + frontSide;
            double greenPaint = totalSurfaceOfHouse / 3;
            double roofPaint = (sideLength * (sideLength / 2) * 2) / 5;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", roofPaint);
        }
    }
}

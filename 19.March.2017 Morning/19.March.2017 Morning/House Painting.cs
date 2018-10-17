using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.March._2017_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double trianglePartOfTheRoof = double.Parse(Console.ReadLine());


            double leftAndRightSides = (height * width) * 2 - (1.5 * 1.5) * 2;
            double frontAndBackSides = Math.Pow(height , 2) * 2 - 2.4;
            double greenPaint = (leftAndRightSides + frontAndBackSides) / 3.4;
            double rectangleRoof = 2 * (height * width);
            double triangleRoof = 2 * (height * trianglePartOfTheRoof / 2);
            double roof = triangleRoof ;
            double redPaint = (roof + rectangleRoof)/4.3 ;
            Console.WriteLine("{0:F2}",greenPaint);
            Console.WriteLine("{0:F2}",redPaint);


        }
    }
}

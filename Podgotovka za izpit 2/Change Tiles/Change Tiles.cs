using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double widthOfFloor = double.Parse(Console.ReadLine());
            double lengthOfFloor = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double hightOfTriangle = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double moneyForMaster = double.Parse(Console.ReadLine());

            double floorArea = widthOfFloor * lengthOfFloor;
            double areaOfTile = (triangleSide * hightOfTriangle)/2;
            double tilesNeedet = Math.Ceiling(floorArea / areaOfTile) + 5;
            double totalSum = tilesNeedet * pricePerTile + moneyForMaster;

            if (money >= totalSum)
            {
                Console.WriteLine("{0:f2} lv left.", money - totalSum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more." , Math.Abs(money - totalSum));
            }
        }
    }
}

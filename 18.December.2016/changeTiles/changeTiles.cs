using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeTiles
{
    class changeTiles
    {
        static void Main(string[] args)
        {
            double gatheredMoney = double.Parse(Console.ReadLine());
            double widthOfFloor = double.Parse(Console.ReadLine());
            double lengthOfFloor = double.Parse(Console.ReadLine());
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double hightOfTriangle = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double moneyForMaster = double.Parse(Console.ReadLine());

            double areaOfFloor = widthOfFloor * lengthOfFloor;
            double areaOfTile = sideOfTriangle * hightOfTriangle / 2;
            double tilesNeedet = Math.Round(areaOfFloor / areaOfTile)+5;
            double totalSum = tilesNeedet * pricePerTile + moneyForMaster;

            

            if (totalSum <= gatheredMoney || totalSum - gatheredMoney ==0)
            {
                double moneyLeft = Math.Abs(gatheredMoney - totalSum);
                Console.WriteLine("{0:F2} lv left.", moneyLeft);
            }
            
            else
            {
                double moneyLeft = Math.Abs(gatheredMoney - totalSum);
                Console.WriteLine("You'll need {0:F2} lv more.", moneyLeft);
            }
            
        }
    }
}

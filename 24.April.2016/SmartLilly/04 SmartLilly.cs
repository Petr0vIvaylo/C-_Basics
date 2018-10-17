using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMashine = double.Parse(Console.ReadLine());
            int presentPrice = int.Parse(Console.ReadLine());

            double numberOfToys = 0;
            double savedMoney = 0;
            double moneyForBirthDay = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {

                    moneyForBirthDay +=moneyForBirthDay - 1;
                    moneyForBirthDay += 10;
                }
                else
                {
                    numberOfToys++;
                }
            }
            savedMoney += numberOfToys * presentPrice;

            Console.WriteLine(savedMoney >=priceOfWashingMashine ?
                $"Yes ! {(savedMoney-priceOfWashingMashine):0.00}" : 
                $"No ! {(priceOfWashingMashine - savedMoney):0.00}");




        }
    }
}

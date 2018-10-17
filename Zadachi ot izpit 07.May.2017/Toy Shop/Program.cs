using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double numberOfPuzzle = double.Parse(Console.ReadLine());
            double numberOfTalkingDolls = double.Parse(Console.ReadLine());
            double numberOfTeddyBears = double.Parse(Console.ReadLine());
            double numberOfMinions = double.Parse(Console.ReadLine());
            double numberOfTrucks = double.Parse(Console.ReadLine());


                double puzzlePrice = 2.6 * numberOfPuzzle;
            double talkingDollsPrice = 3 * numberOfTalkingDolls;
            double teddyBearsPrice = 4.1 * numberOfTeddyBears;
            double minionPrice = 8.2 * numberOfMinions;
            double truckPrice = 2 * numberOfTrucks;

            double totalToysCount = numberOfPuzzle + numberOfTalkingDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;

            if (totalToysCount >= 50)
            {
                double totalMoneyForToys = (puzzlePrice + talkingDollsPrice + teddyBearsPrice + minionPrice + truckPrice) ;
                double totalMoneyForToysAfterDiscount = totalMoneyForToys - (totalMoneyForToys * 0.25);
                double moneyForRent = totalMoneyForToysAfterDiscount * 0.1;
                double earnings = totalMoneyForToysAfterDiscount - moneyForRent;

                if (earnings > vacationPrice)
                {
                    double moneyAfterVacation = Math.Abs(earnings - vacationPrice);
                    Console.WriteLine("Yes! {0:F2} lv left.", moneyAfterVacation);
                }
                
                
            }
            else
            {
                double totalMoneyForToys = (puzzlePrice + talkingDollsPrice + teddyBearsPrice + minionPrice + truckPrice);

                double moneyForRent = totalMoneyForToys * 0.1;
                double earnings = totalMoneyForToys - moneyForRent;
                double moneyAfterVacation = Math.Abs(earnings - vacationPrice);
                Console.WriteLine("Not enough money! {0:F2} lv needed.", moneyAfterVacation);
            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTicket
{
    class MatchTicket
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category= (Console.ReadLine());
            double numberOfPeopleInGroup = double.Parse(Console.ReadLine());

            double transportCost = 0;
            double ticketPrice = 0;

            if (numberOfPeopleInGroup >= 1 && numberOfPeopleInGroup <= 4 )
            {
                transportCost = budget -  budget * 0.75;
            }
            else if (numberOfPeopleInGroup >= 5 && numberOfPeopleInGroup <= 9 )
            {
                transportCost = budget - budget * 0.6;
            }
            else if (numberOfPeopleInGroup >= 10 && numberOfPeopleInGroup <= 24)
            {
                transportCost = budget - budget * 0.5;
            }
            else if (numberOfPeopleInGroup >= 25 && numberOfPeopleInGroup <= 49)
            {
                transportCost = budget - budget * 0.4;
            }
            else if (numberOfPeopleInGroup >= 50 )
            {
                transportCost = budget - budget * 0.25;
            }
            if (category == "Normal")
            {
                 ticketPrice = 249.99;
            }
            else if (category == "VIP")
            {
                 ticketPrice = 499.99;
            }

            double expencies = ticketPrice * numberOfPeopleInGroup;

            if (expencies <= transportCost)
            {
                double moneyLeft = transportCost - expencies  ;
                Console.WriteLine("Yes! You have {0:F2} leva left." , moneyLeft);
            }
            else
            {
                double moneyLeft = Math.Abs(expencies - transportCost);
                Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyLeft);
            }

        }
    }
}

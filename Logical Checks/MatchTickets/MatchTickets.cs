using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string kategory = Console.ReadLine();
             double peopleNumber = double.Parse(Console.ReadLine());

            if (peopleNumber <= 4)
            {

                double travelExpencies = budget-(budget * 0.75);
                
                if (kategory == "VIP")
                {
                    double ticketPrice = travelExpencies - 499.99;
                   
                    Console.WriteLine("Yes!You have {0:F2} leva left.", ticketPrice);
                }
                else if (kategory == "Normal")
                {
                    double ticketPrice= travelExpencies - 249.99;
                   
                    Console.WriteLine("Yes!You have {0:F2} leva left.", ticketPrice);
                }
 
                
            }





        }
    }
}

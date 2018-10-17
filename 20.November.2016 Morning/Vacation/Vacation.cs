using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double numberOfAdults = double.Parse(Console.ReadLine());
            double numberOfKids = double.Parse(Console.ReadLine());
            double numberOfNights = double.Parse(Console.ReadLine());
            string transport =Console.ReadLine();

            double adultTicketPrice = 0;
            double kidsTicketPrice = 0;
            double pricePerNight = 82.99;

            if (transport == "train")
            {
                
                 adultTicketPrice = numberOfAdults * 24.99;
                 kidsTicketPrice = numberOfKids * 14.99;
                if (numberOfAdults + numberOfKids >= 50)
                {
                    adultTicketPrice = (numberOfAdults * 24.99) / 2;
                    kidsTicketPrice = (numberOfKids * 14.99) / 2;
                }
            }
            else if (transport == "bus")
            {
                 adultTicketPrice = numberOfAdults * 32.5;
                 kidsTicketPrice = numberOfKids * 28.5;
            }
            else if (transport == "boat")
            {
                 adultTicketPrice = numberOfAdults * 42.99;
                 kidsTicketPrice = numberOfKids * 39.99;
            }
            else if (transport == "airplane")
            {
                 adultTicketPrice = numberOfAdults * 70;
                 kidsTicketPrice = numberOfKids * 50;
            }
            

            double transportCost = (adultTicketPrice + kidsTicketPrice) * 2;
            double hotelCost = numberOfNights * pricePerNight;
            double commision = (transportCost + hotelCost) * 0.1;
            double totalCost = transportCost + hotelCost + commision;

            Console.WriteLine("{0:F2}", totalCost);
        }
    }
}

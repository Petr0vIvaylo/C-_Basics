using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string cinemaType = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (cinemaType == "premiere")
            {
                int ticketPrice = 12;
                double income = (double)(ticketPrice * row * col);
                Console.WriteLine("{0:f2} leva" , income);
            }
            else if (cinemaType == "normal")
            {
                
                double ticketPrice = 7.5;
                double income = (double)(ticketPrice * row * col);
                Console.WriteLine("{0:f2} leva", income);
            }
            else if (cinemaType == "discount")
            {
                double ticketPrice = 5;
                double income = (double)(ticketPrice * row * col);
                Console.WriteLine("{0:f2} leva", income);
            }
        }
    }
}

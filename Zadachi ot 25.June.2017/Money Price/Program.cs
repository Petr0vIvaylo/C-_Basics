using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double projectPieces = double.Parse(Console.ReadLine());
            double moneyForPeice = double.Parse(Console.ReadLine());

            double evenSum = 0;
            double oddSum = 0;

            for (int i = 0; i < projectPieces; i ++)
            {
                double m = double.Parse(Console.ReadLine());
                if (i % 2 == 0 )
                {
                    oddSum += m;
                }
                else
                {
                    evenSum += (m * 2);
                }
                
            }

            
                
            
            double prize = (oddSum + evenSum) * moneyForPeice;


            Console.WriteLine("The project prize was {0:F2} lv.", prize);
            
            

        }
    }
}

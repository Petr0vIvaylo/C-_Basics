using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToPast
{
    class BackToPast
    {
        static void Main(string[] args)
        {
            double Money = double.Parse(Console.ReadLine());
            double yearHeMustLive = double.Parse(Console.ReadLine());

            double moneyLeft = Money;
            double ivanchoYearsOld = 18;

            for (int i = 1800; i <= yearHeMustLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneyLeft -=  12000;
                }
                else
                {
                   
                    moneyLeft -= (12000 + ivanchoYearsOld *50 );
                }
                ivanchoYearsOld++;
            }
            if (moneyLeft < 0 )
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(moneyLeft));
            }
            else
            {
                
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", moneyLeft);
            }
           


        }
    }
}

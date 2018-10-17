using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Delene_bez_Ostatk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0 )
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            double percentDivideByTwo = (p1 / n)*100;
            double percentDivideBythree = (p2 / n)*100;
            double percentDivideByFour = (p3 / n)*100;


            Console.WriteLine("{0:F2}%",percentDivideByTwo);
            Console.WriteLine("{0:F2}%",percentDivideBythree);
            Console.WriteLine("{0:F2}%",percentDivideByFour);
        }
    }
}

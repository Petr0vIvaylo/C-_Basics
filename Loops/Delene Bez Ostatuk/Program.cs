﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delene_Bez_Ostatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0 )
                {
                    p1++;
                }
                if (currentNumber % 3 == 0)
                {
                    p2++;
                }
                if (currentNumber % 4 == 0 )
                {
                    p3++;
                }

            }
            Console.WriteLine("{0:F2}%", p1 / n*100);
            Console.WriteLine("{0:F2}%", p2 / n*100);
            Console.WriteLine("{0:F2}%", p3 / n*100);



        }
    }
}

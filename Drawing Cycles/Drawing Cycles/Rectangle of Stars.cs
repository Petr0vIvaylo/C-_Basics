﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
        }
    }
}

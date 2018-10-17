using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowFlake
{
    class SnowFlake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n-1; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int col = 0; col < n-row; col++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < n-row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n-1; i++)
            {
                    Console.Write(".");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();


            for (int i = 0; i < 2*n+3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();


            for (int row = 0; row < n - 1; row++)
            {
                for (int i = 0; i < n-2-row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int col = 0; col < 2 + row; col++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < 2 + row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < n - 2 - row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

        }
    }
}

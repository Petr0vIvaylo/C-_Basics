using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('#', 4 * n + 1));
            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= row; col++)
                {
                    Console.Write(".");
                }

                for (var col = 2 * n; col >= 2 * row; col--)
                {
                    Console.Write("#");
                }
                Console.Write(" ");
                for (var col = 1; col <= row - 1; col++)
                {
                    Console.Write(" ");
                }

                for (var col = 1; col <= row - 1; col++)
                {
                    Console.Write(" ");
                }
                for (var col = 2 * n; col >= 2 * row; col--)
                {
                    Console.Write("#");
                }
                for (var col = 1; col <= row; col++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();


            }

            for (int row = 1; row <= n; row++)
            {
                for (int col = n + 1; col <= 2 * n + row; col++)
                {
                    Console.Write(".");
                }
                for (var col = 2 * n; col >= 2 * row; col--)
                {
                    Console.Write("#");
                }
                for (int col = n + 1; col <= 2 * n + row; col++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}

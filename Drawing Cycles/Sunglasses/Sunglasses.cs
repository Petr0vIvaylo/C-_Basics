using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //firstLine
            for (int i = 0; i < n*2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //midLine
            
            var noseIndex = (n - 1) / 2 - 1;
            for (int row = 0; row < n-2; row++)
            {
                if (row != (n - 1) / 2 - 1)
                {
                    Console.Write("*");
                    for (int i = 0; i < n * 2 - 2; i++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int i = 0; i < n * 2 - 2; i++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    for (int i = 0; i < n * 2 - 2; i++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("|");
                    }
                    Console.Write("*");
                    for (int i = 0; i < n * 2 - 2; i++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
            
            



            //lastLine
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

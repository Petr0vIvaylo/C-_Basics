using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n-2; i++)
            {
                if (i % 2 == 0)
                {
                    for (int row = 0; row < n - 2; row++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    for (int k = 0; k < n - 2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int row = 0; row < n - 2; row++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
            Console.Write(new string (' ',n-1));
            Console.Write("@");
            Console.WriteLine(new string(' ', n - 1));
            
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    for (int row = 0; row < n - 2; row++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    for (int k = 0; k < n - 2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int row = 0; row < n - 2; row++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    for (int j = 0; j < n - 2; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}

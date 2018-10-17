using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_whit_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;

            for (int i = 0; i < 2*n; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();

            if (n % 2 ==0)
            {
                number--;
               
                for (int i = 0; i < number/2; i++)
                {
                    Console.Write("%");
                    for (int j = 0; j < 2*n-2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("%");
                    for (int j = 0; j < 2 * n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
            }

            Console.Write("%");
            for (int i = 0; i < (n*2-4)/2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.Write("*");
            for (int i = 0; i < (n * 2 - 4)/2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("%");
            Console.WriteLine();

            if (n % 2 == 0)
            {
                number--;

                for (int i = 0; i < number / 2; i++)
                {
                    Console.Write("%");
                    for (int j = 0; j < 2 * n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write("%");
                    for (int j = 0; j < 2 * n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();
        }
    }
}

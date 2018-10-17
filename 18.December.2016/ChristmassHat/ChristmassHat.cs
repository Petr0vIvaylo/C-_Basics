using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmassHat
{
    class ChristmassHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2*n-1; i++)
            {
                Console.Write(".");
            }
            Console.Write("/"); 
            Console.Write("|");
            Console.Write("\\");
            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            for(int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("\\");
            Console.Write("|");
            Console.Write("/");
            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            for(int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("***");
            
            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();


            for(int row = 0; row < 2 * n - 1; row++)
            {
                for (int i = 0; i < 2*n-2-row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < 2 * n - 2 - row; i++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }
            Console.WriteLine(new string ('*',4*n+1));
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
            



        }
    }
}

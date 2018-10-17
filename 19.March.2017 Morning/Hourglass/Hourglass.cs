using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine(new string ('*',2*n+1));
            Console.Write(".");
            Console.Write("*");
            Console.Write(new string (' ',2*n-3));
            Console.Write("*");
            Console.Write(".");
            Console.WriteLine();


            for (int row = 0; row < n-2; row++)
            {
                for (int dots = 0; dots <= row+1; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("*");

                for (int at = 0; at < 2*n-5-2*row; at++)
                {
                    Console.Write("@");
                }
                Console.Write("*");
                for (int dots = 0; dots <= row + 1; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.Write(new string('.',  n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));


            for (int row = 0; row < n - 2; row++)
            {
                for (int dots = n-1; dots >= row + 1; dots--)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(" ");
                } 
                Console.Write("@");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(" ");
                } 
                
                Console.Write("*");
                
                for (int dots = n - 1; dots >= row + 1; dots--)
                {
                    
                    Console.Write(".");
                    
                }
                
                Console.WriteLine();
            }
            Console.Write(".");
            Console.Write("*");
            Console.Write(new string('@', 2 * n+1 -4 ));
            Console.Write("*");
            Console.WriteLine(".");
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}

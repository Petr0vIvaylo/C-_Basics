using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamant
{
    class Diamant
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string ('.',n));
            Console.Write(new string('*', 3*n));
            Console.WriteLine(new string('.', n));
            for (int row = 0; row < n-1; row++)
            {
                for (int i = 0; i < n-row-1; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < 3*n + 2*row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < n - row - 1; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine(new string ('*',5*n));

            for (int row = 0; row < 2*n; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i < 5*n-4-2*row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int i = 0; i <= row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.Write(new string ('.',2*n+1));
            Console.Write(new string('*', n-2));
            Console.WriteLine(new string('.', 2 * n + 1));
        }
    }
}

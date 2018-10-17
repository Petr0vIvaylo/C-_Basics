using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < (3*n-2)/2 -row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("/");

                for (int i = 1; i <= 0 + row*2; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for (int i = 0; i < (3 * n - 2) / 2 - row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.Write(new string ('.',n/2));
            Console.Write(new string('*', 2*n));
            Console.WriteLine(new string('.', n / 2));

            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("|");
                Console.Write(new string('\\', 2 * n-2));
                Console.Write("|");
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }

            for (int row = 0; row < n/2; row++)
            {
                for (int i = 0; i < n / 2 - row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("/");

                for (int i = 1; i <= (2*n -2)+row*2; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                for (int i = 0; i < n / 2 - row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < 3*n; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 1; i < 1+row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < 2*n-2-row; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                
            }
            for (int row = 0; row < n / 2; row++)
            {
                for (int coli = 0; coli < 3 * n+1; coli++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < n-1; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < n-1; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            for (int row = 0; row < n/2 -1; row++)
            {
                for (int i = 0; i < 3*n-row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < n-1 + 2*row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = 0; i < n-1-row; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            if (n % 2 ==0)
            {
                for (int i = 0; i < 2.5*n+1; i++)
                {
                    Console.Write("-");
                }
                
                for (int i = 0; i < 2*n-1; i++)
                {
                    Console.Write("*");
                }
                
                for (int i = 0; i < n/2; i++)
                {
                    Console.Write("-");
                }
            }
            else
            {
                for (int i = 0; i < 3*n-n/2+1; i++)
                {
                    Console.Write("-");
                }

                for (int i = 0; i < 2 * n - 2; i++)
                {
                    Console.Write("*");
                }

                for (int i = 0; i < n / 2+1; i++)
                {
                    Console.Write("-");
                }
            }


            
        }
    }
}

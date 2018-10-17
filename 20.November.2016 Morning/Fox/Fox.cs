using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                for (int i = 0; i < (2*n-1)-2*row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("/");
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < n/3; i++)
            {
                Console.Write("|");
                for (int col = 0; col < n/2+i; col++)
                {
                    Console.Write("*");
                }
                Console.Write("\\");
                for (int stars = 0; stars < n-2*i; stars++)
                {
                    Console.Write("*");
                }
                Console.Write("/");
                for (int col = 0; col < n / 2 + i; col++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("\\");
                for (int i = 0; i < (2 * n - 1) - 2 * row; i++)
                {
                    Console.Write("*");
                }
                Console.Write("/");
                for (int i = 0; i <= row; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }


        }
    }
}

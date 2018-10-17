using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < n-row-1; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < row; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();

            }


            for (int row = 0; row <n- 1; row++)
            {
                for (int i = 0; i <= row; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = n-1; j > row+1; j--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();

            }
        }
    }
}

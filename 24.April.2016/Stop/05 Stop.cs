using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            #region FirstRow
            for (int i = 0; i < n+1; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write("_");
            }
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion

            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < n-row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("//");
                for (int i = 0; i < 2*n-1+2*row; i++)
                {
                    Console.Write("_");
                }
                Console.Write(@"\\");
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            Console.Write("//");
            for (int i = 0; i < 2*n-3; i++)
            {
                Console.Write("_");
            }
            Console.Write("STOP!");
            for (int i = 0; i < 2*n-3; i++)
            {
                Console.Write("_");
            }
            Console.Write(@"\\");
            Console.WriteLine();

            for (int bottomPart  = 0; bottomPart < n; bottomPart++)
            {
                for (int col = 0; col < bottomPart; col++)
                {
                    Console.Write(".");
                }
                Console.Write(@"\\");
                for (int dashes = 0; dashes < 4*n-2*bottomPart-1; dashes++)
                {
                    Console.Write("_");
                }
                Console.Write("//");
                for (int col = 0; col < bottomPart; col++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

        }
    }
}

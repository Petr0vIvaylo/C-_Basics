using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            #region firstRow

            for (int i = 0; i < 3*n/2; i++)
            {
                Console.Write(".");
            }
            Console.Write("x");
            for (int i = 0; i < 3 * n / 2; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion
            #region secondRow
            for (int i = 0; i < 3 * n / 2-1; i++)
            {
                Console.Write(".");
            }
            Console.Write("/");
            Console.Write("x");
            Console.Write("\\");
            for (int i = 0; i < 3 * n / 2-1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion
            #region thirdRow
            for (int i = 0; i < 3 * n / 2-1; i++)
            {
                Console.Write(".");
            }
            Console.Write("x");
            Console.Write("|");
            Console.Write("x");
            for (int i = 0; i < 3 * n / 2-1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion

            for (int row = 0; row < n/2; row++)
            {
                for (int i = 0; i < (3 * n / 2)-n-row; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < n+row; i++)
                {
                    Console.Write("x");
                }
                Console.Write("|");
                for (int i = 0; i < n+row; i++)
                {
                    Console.Write("x");
                }
                for (int i = 0; i < (3 * n / 2) - n - row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3*n/2; i++)
            {
                Console.Write("x");
            }
            Console.Write("|");
            for (int i = 0; i < 3 * n / 2; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();

            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < n / n + row; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < (3 * n / 2) - 1 - row; i++)
                {
                    Console.Write("x");
                }
                Console.Write("|");
                for (int i = 0; i < (3 * n / 2) - 1 - row; i++)
                {
                    Console.Write("x");
                }
                for (int i = 0; i < n / n + row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            #region secondRow
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("/");
            Console.Write("x");
            Console.Write("\\");
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion

            #region secondRow
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("\\");
            Console.Write("x");
            Console.Write("/");
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion

            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < (3 * n / 2) - n - row; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < n + row; i++)
                {
                    Console.Write("x");
                }
                Console.Write("|");
                for (int i = 0; i < n + row; i++)
                {
                    Console.Write("x");
                }
                for (int i = 0; i < (3 * n / 2) - n - row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3 * n / 2; i++)
            {
                Console.Write("x");
            }
            Console.Write("|");
            for (int i = 0; i < 3 * n / 2; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine();

            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < n/n + row; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < (3 * n / 2)-1 - row; i++)
                {
                    Console.Write("x");
                }
                Console.Write("|");
                for (int i = 0; i < (3 * n / 2)-1 - row; i++)
                {
                    Console.Write("x");
                }
                for (int i = 0; i < n/n + row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            #region thirdRow
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("x");
            Console.Write("|");
            Console.Write("x");
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion
            #region secondRow
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("\\");
            Console.Write("x");
            Console.Write("/");
            for (int i = 0; i < 3 * n / 2 - 1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion
            #region firstRow

            for (int i = 0; i < 3 * n / 2; i++)
            {
                Console.Write(".");
            }
            Console.Write("x");
            for (int i = 0; i < 3 * n / 2; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            #endregion
            
        }
    }
}

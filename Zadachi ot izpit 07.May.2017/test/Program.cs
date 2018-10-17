using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                for (var col = 0; col < n - i; col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
    }
}

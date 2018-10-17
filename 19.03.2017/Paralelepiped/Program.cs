using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.Write("+");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("~");
            }
            Console.Write("+");
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            


            for (int secondRow =0 ; secondRow < 2*n+1; secondRow++)
            {
                Console.Write("|");
                for (int i = 0; i < secondRow; i++)
                {
                    Console.Write(".");
                }
                Console.Write("\\");
                Console.Write(new string('~', n - 2));
                Console.Write("\\");
                Console.Write(new string('.', n * 2 - secondRow));
                Console.WriteLine();
            }
            for (int bottomPart = 0; bottomPart < 2*n+1; bottomPart++)
            {
                
                for (int i = 0; i < bottomPart; i++)
                {
                    Console.Write(".");
                }
                Console.Write("\\");
                Console.Write(new string('.', n * 2 - bottomPart));
                Console.Write("|");
                Console.Write(new string('~', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.Write(".");
            }
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("~");
            }
            Console.Write("+");






        }
    }
}

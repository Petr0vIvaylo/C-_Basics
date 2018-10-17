using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n / 2; row++)
            {

                for (int i = 0; i < n + row; i++)
                {
                    Console.Write(".");
                }
                for (int hashTag = 0; hashTag < 1.5 * n - row; hashTag++)
                {
                    Console.Write("#");
                }

                for (int hashTag = 0; hashTag < 1.5 * n - row; hashTag++)
                {
                    Console.Write("#");
                }
                for (int i = 0; i < n+row; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }


            for (int middlePartRow = 0; middlePartRow < n / 2 + 1; middlePartRow++)
            {
                for (int dots = 0; dots < 1.5 * n + middlePartRow; dots++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int i = 0; i < (n-1)-middlePartRow; i++)
                {
                    Console.Write(".");
                }
                for (int i = 0; i < (n - 1) - middlePartRow; i++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int dots = 0; dots < 1.5 * n + middlePartRow; dots++)
                {
                    Console.Write(".");
                }
                    Console.WriteLine();
            }



            for (int i = 0; i < 1; i++)
            {
                for (int fixedDots = 0; fixedDots < 2 * n; fixedDots++)
                {
                    Console.Write(".");
                }
                for (int fixedHashtags = 0; fixedHashtags < n; fixedHashtags++)
                {
                    Console.Write("#");
                }
                for (int fixedDots = 0; fixedDots < 2 * n; fixedDots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }



            for (int bottomPart = 0; bottomPart < n/2; bottomPart++)
            {
                for (int dots = 0; dots < 2*n-2; dots++)
                {
                    Console.Write(".");
                }
                for (int dots = 0; dots < n+4; dots++)
                {
                    Console.Write("#");
                }
                for (int dots = 0; dots < 2 * n - 2; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }



            for (int danceLine = 0; danceLine < 1; danceLine++)
            {
                for (int dots = 0; dots < ((5*n)-10)/2 ; dots++)
                {
                    Console.Write(".");
                }
                for (int dots = 0; dots < 1; dots++)
                {
                    Console.Write("D^A^N^C^E^");
                }
                for (int dots = 0; dots < ((5 * n) - 10) / 2; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }


            for (int bottomPart = 0; bottomPart < n / 2+1; bottomPart++)
            {
                for (int dots = 0; dots < 2 * n - 2; dots++)
                {
                    Console.Write(".");
                }
                for (int dots = 0; dots < n + 4; dots++)
                {
                    Console.Write("#");
                }
                for (int dots = 0; dots < 2 * n - 2; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
 
        }
    }
}

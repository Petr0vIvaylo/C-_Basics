using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.Write(new string ('.',(12*n-6)/2));
            Console.Write("#");
            Console.WriteLine(new string('.', (12 * n - 6) / 2));


            for (int row = 0; row < 2*n-1; row++)
            {
                for (int dots = 0; dots < 6*n-6-row*3; dots++)
                {
                    Console.Write(".");
                }
                for (int hashTags = 0; hashTags < 6+row*6; hashTags++)
                {
                    Console.Write("#");
                }
                Console.Write("#");
                for (int dots = 0; dots < 6 * n - 6 - row * 3; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }




            for (int i = 0; i < n-2; i++)
            {
                Console.Write("|");
                Console.Write("..");
                Console.Write(new string('.', i * 3));
                Console.Write(new string('#', 12 * n - 11-i*6));
                Console.Write(new string('.',3+i*3));
                Console.WriteLine();
            }


            for (int bottomPart = 0; bottomPart < n - 1; bottomPart++)
            {
                Console.Write("|");
                for (int dots = 0; dots < 3*n-4; dots++)
                {
                    Console.Write(".");
                }
                for (int hashTags = 1; hashTags <= 6*n+1; hashTags++)
                {
                    Console.Write("#");
                }
                for (int dots = 0; dots < 3 * n - 3; dots++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.Write("@");
            for (int dots = 0; dots < 3 * n - 4; dots++)
            {
                Console.Write(".");
            }
            for (int hashTags = 1; hashTags <= 6 * n + 1; hashTags++)
            {
                Console.Write("#");
            }
            for (int dots = 0; dots < 3 * n - 3; dots++)
            {
                Console.Write(".");
            }
            Console.WriteLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqare_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int firstRow = 0; firstRow < n-2; firstRow++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int middle = 0; middle < n-2; middle++)
            {
                Console.Write("| ");
                for (int i = 0; i < n-2; i++)
                {
                    
                    Console.Write("- ");
                    
                }
                Console.Write("|");
                Console.WriteLine();
            }
            

            Console.Write("+ ");

            for (int lastRow = 0; lastRow< n - 2; lastRow++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

        }
    }
}

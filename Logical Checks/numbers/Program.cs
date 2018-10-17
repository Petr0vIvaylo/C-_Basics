using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (userInput >= 100 && userInput <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (userInput > 200)
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}

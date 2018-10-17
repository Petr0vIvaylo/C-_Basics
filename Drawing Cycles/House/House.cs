using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // roof of House
            int numberOfRows = (n / 2) + n % 2;
            int numberOfStars = 0;

            if (n % 2 == 0 )
            {
                numberOfStars = 2;
            }
            else
            {
                numberOfStars = 1;
            }
            for (int i = 0; i < numberOfRows; i++)
            {
                int numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
                numberOfStars += 2;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write('|');
                Console.Write(new string ('*' , n-2));
                Console.WriteLine('|');
            }
        }
    }
}

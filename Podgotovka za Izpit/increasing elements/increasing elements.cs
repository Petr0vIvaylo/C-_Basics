using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increasing_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countCurrentLongest = 0;
            int currentLongest = 0;
            int numbersPrev = 0;
            int numbers = 0;
           
            for (int i = 0; i < n; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (numbers > numbersPrev)
                {
                    countCurrentLongest++;
                }
                else
                {
                    countCurrentLongest = 1;
                }
                if (countCurrentLongest > currentLongest)
                {
                    currentLongest = countCurrentLongest;
                }
                numbersPrev = numbers;

            }
            Console.WriteLine(currentLongest);

        }
    }
}

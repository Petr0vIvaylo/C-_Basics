using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                if (numberInput < num)
                {
                    num = numberInput;

                }
            }
            Console.WriteLine(num);
        }
    }
}


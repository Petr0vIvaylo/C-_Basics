using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double numberInput = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numberInput;
                    evenMin = Math.Min(evenMin , numberInput);
                    evenMax = Math.Max(evenMax, numberInput);
                }
                else
                {
                    oddSum += numberInput;
                    oddMin = Math.Min(oddMin, numberInput);
                    oddMax = Math.Max(oddMax, numberInput);
                }
            }
                Console.WriteLine("OddSum=" + oddSum + ",");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin + ",");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax + ",");
            }
            Console.WriteLine("EvenSum=" + evenSum + ",");

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin + ",");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }

    }
}


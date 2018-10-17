using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int greatestNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > greatestNumber)
                {
                    greatestNumber = currentNumber;
                }
            }
            sum -= greatestNumber;
            if (sum == greatestNumber)
            {
                Console.WriteLine("Yes\nSum = {0}" , sum);
            }
            else
            {
                int difference = Math.Abs(greatestNumber - sum);
                Console.WriteLine("No\nDiff = {0}", difference);
            }
        }
    }
}

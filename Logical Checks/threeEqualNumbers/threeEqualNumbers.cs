using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeEqualNumbers
{
    class threeEqualNumbers
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thurdNumber = double.Parse(Console.ReadLine());

            double dividetSum=firstNumber+secondNumber+thurdNumber

            if (dividetSum % 3 == 0) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

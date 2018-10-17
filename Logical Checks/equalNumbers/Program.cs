using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thurdNumber = double.Parse(Console.ReadLine());

            if (   firstNumber == secondNumber 
                && firstNumber == thurdNumber 
                && secondNumber == firstNumber 
                && secondNumber == thurdNumber
                && thurdNumber == firstNumber 
                && thurdNumber == secondNumber)
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

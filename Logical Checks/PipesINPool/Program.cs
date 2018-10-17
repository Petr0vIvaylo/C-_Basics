using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesINPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double totalPipeFill =pipeOne * hours + pipeTwo * hours;


            if (totalPipeFill <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%."
                , Math.Truncate((totalPipeFill / v) * 100),
                Math.Truncate(pipeOne * hours / totalPipeFill * 100),
                Math.Truncate(pipeTwo * hours / totalPipeFill * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters." ,
                    hours, totalPipeFill-v);
            }

        }
    }
}

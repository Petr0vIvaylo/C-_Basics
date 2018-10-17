using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pipes_in_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1Total = p1 * h;
            double p2Total = p2 * h;
            double pipesTotal = p1Total + p2Total;

            if (pipesTotal <= v)
            {
                double poolISFull = Math.Truncate((pipesTotal / v) * 100);
                double pipeOne = Math.Truncate((p1Total / pipesTotal) * 100);
                double pipeTwo = Math.Truncate((p2Total / pipesTotal) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%."
                    , poolISFull , pipeOne , pipeTwo);
            }

            else
            {
                double poolOverFlow = Math.Abs(pipesTotal - v);

                Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters.",h , poolOverFlow);
            }

        }
    }
}

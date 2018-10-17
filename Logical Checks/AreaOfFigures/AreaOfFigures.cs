using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double squareArea = a * a;
                Console.WriteLine("{0:F3}",squareArea);
            }
            else if (figure=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double squareArea = a *b;
                Console.WriteLine("{0:F3}", squareArea);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double circleArea = Math.PI*( r * r);
                Console.WriteLine("{0:F3}", circleArea);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = (a * h)/2;
                Console.WriteLine("{0:F3}", triangleArea);
            }
        }
    }
}

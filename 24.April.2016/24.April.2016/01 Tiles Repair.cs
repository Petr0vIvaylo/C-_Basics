using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.April._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double areaSize = n * n;
            double benchSize = m * o;
            double tileArea = w * l;

            double tilesNeedet = (areaSize - benchSize) / (tileArea);
            double time = tilesNeedet * 0.2;

            Console.WriteLine("{0:F2}", tilesNeedet);
            Console.WriteLine("{0:F2}", time);
        }
    }
}

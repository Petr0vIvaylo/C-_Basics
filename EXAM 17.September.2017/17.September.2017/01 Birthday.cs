using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.September._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = (length * width * height) * 0.001;
            double waterNeedet = volume * (1 - (percent * 0.01));
            Console.WriteLine("{0:F3}", waterNeedet);
        }
    }
}

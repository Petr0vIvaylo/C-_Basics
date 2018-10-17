using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            

            double widthWorkArea = Math.Floor((width * 100)  / 120);
            double heightWorkArea = Math.Floor((height * 100 - 100)  / 70);
            double maxWorkPlaces = widthWorkArea * heightWorkArea;
            Console.WriteLine(widthWorkArea);
            Console.WriteLine(heightWorkArea);
            Console.WriteLine(maxWorkPlaces);
        }
    }
}

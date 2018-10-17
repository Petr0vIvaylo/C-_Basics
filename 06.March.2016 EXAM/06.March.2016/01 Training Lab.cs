using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.March._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double widthWorkingDesk =Math.Floor (((width * 100) - 100) / 70);
            double lengthWorkingDesk = Math.Floor ((length * 100) / 120);
            double totalDesks = widthWorkingDesk * lengthWorkingDesk - 3;
            
            Console.WriteLine("{0}", totalDesks);
        }
    }
}

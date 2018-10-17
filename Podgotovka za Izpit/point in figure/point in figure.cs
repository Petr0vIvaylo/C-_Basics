using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_in_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool pointInrectangle1 = x >= 2 && x <= 12 && y >= -3 && y <= 1;
            bool pointInrectangle2 = x >= 4 && x <= 10 && y >= -5 && y <= 3;


            if (pointInrectangle1 || pointInrectangle2)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }


        }
    }
}

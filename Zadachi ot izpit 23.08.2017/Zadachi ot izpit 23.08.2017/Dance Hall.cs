using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double roomSize = (L * 100) * (W * 100);
            double locker = (A*100)*(  A* 100);
            double benchSize = (roomSize / 10);
            double freeSpace = (roomSize - locker - benchSize);
            double numberDancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor( numberDancers));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class sumSeconds
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime= int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double totalTime = firstTime + secondTime + thirdTime;
            int minutes = (int)totalTime / 60;
            double seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }


        }
    }
}

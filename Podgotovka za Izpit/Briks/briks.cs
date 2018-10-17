using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briks
{
    class briks
    {
        static void Main(string[] args)
        {
            int numberOfBriks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int trolly = int.Parse(Console.ReadLine());

            int briksInOneCourse = workers * trolly;
            double totalCourses =Math.Ceiling((double)numberOfBriks / briksInOneCourse);
            Console.WriteLine(totalCourses);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company
    {
        static void Main(string[] args)
        {
            double workingHoursNeedet = double.Parse(Console.ReadLine());
            double daysForFinish = double.Parse(Console.ReadLine());
            double numberOfOverTimeWorkers = double.Parse(Console.ReadLine());

            double workingHoursAfterEducation = (daysForFinish - daysForFinish * 0.1) * 8 ;
            double overTimeWork = numberOfOverTimeWorkers * 2 * daysForFinish;
            double totalHours = Math.Floor(workingHoursAfterEducation + overTimeWork);

            if (totalHours >= workingHoursNeedet)
            {
                double hoursLeft = totalHours - workingHoursNeedet;
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }
            else
            {

                double hoursLeft = Math.Abs(totalHours - workingHoursNeedet);
                Console.WriteLine("Not enough time!{0} hours needed.", hoursLeft);
            }
            
        }
    }
}

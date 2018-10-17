using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());

            double sreden = 0;
            double dobur = 0;
            double mnogoDobur = 0;
            double otlichen = 0;
            double sum = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                sum += grades;
                if (grades >= 2 && grades <= 2.99)
                {
                    sreden++;
                }
                else if (grades >= 3 && grades <= 3.99)
                {
                    dobur++;
                }
                else if (grades >= 4 && grades <= 4.99)
                {
                    mnogoDobur++;
                }
                else if (grades >= 5 )
                {
                    otlichen++;
                }
            }

            sreden /= numberOfStudents / 100;
            dobur /= numberOfStudents / 100;
            mnogoDobur /= numberOfStudents / 100;
            otlichen /= numberOfStudents / 100;
            double average = sum / numberOfStudents;
            Console.WriteLine("Top students: {0:F2}%" ,otlichen);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",mnogoDobur);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",dobur);
            Console.WriteLine("Fail: {0:f2}%",sreden);
            Console.WriteLine("Average: {0:f2}",average);
        }
    }
}

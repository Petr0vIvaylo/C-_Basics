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

            double ocenkaTri = 0;
            double ocenkaChetiri = 0;
            double ocenkaPet = 0;
            double ocenkaOtlichen = 0;
            double ocenkiSum = 0;



            for (int i = 0; i < numberOfStudents; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                ocenkiSum += grades;
                if (grades >= 2 && grades <=2.99)
                {
                    ocenkaTri += 1;
                }
                else if (grades >= 3 && grades <= 3.99)
                {
                    ocenkaChetiri += 1;
                }
                else if (grades >= 4 && grades <= 4.99)
                {
                    ocenkaPet += 1;
                }
                else if (grades >= 5 && grades <= 6)
                {
                    ocenkaOtlichen += 1;
                }
            }

            double averageGrades = ocenkiSum / numberOfStudents;
            double top = (ocenkaOtlichen / numberOfStudents) * 100;
            double good = (ocenkaPet / numberOfStudents) * 100; 
            double mid = (ocenkaChetiri / numberOfStudents) * 100;
            double fail = (ocenkaTri / numberOfStudents) * 100;

            Console.WriteLine("Top students: {0:F2}%", top);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", good);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", mid);
            Console.WriteLine("Fail: {0:F2}%", fail);
            Console.WriteLine("Average: {0:F2}", averageGrades);
        }
    }
}

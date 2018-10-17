using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trainers_Selary
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfLections = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            //string lectorName = Console.ReadLine();
            int lectionsJelev = 0;
            int lectionsRoYaL = 0;
            int lectionsRoli = 0;
            int lectionsTrofon = 0;
            int lectionsSino = 0;
            int lectionsOthers = 0;

            for (int i = 0; i < numberOfLections; i++)
            {
                string lectorName = Console.ReadLine();
                if (lectorName == "Jelev")
                {
                    lectionsJelev += 1;
                }
                else if (lectorName == "RoYaL")
                {
                    lectionsRoYaL += 1;
                }
                else if (lectorName == "Roli")
                {
                    lectionsRoli += 1;
                }
                else if (lectorName == "Trofon")
                {
                    lectionsTrofon += 1;
                }
                else if (lectorName == "Sino")
                {
                    lectionsSino += 1;
                }
                else  
                {
                    lectionsOthers += 1;
                }
            }

            double Jelevsalary = (budget / numberOfLections) * lectionsJelev;
            double RoYaLsalary = (budget / numberOfLections) * lectionsRoYaL;
            double Rolisalary =   (budget / numberOfLections) * lectionsRoli ;
            double Trofonsalary = (budget / numberOfLections) * lectionsTrofon;
            double Sinosalary = (budget / numberOfLections) * lectionsSino;
            double Othersalary = (budget / numberOfLections) * lectionsOthers;

            Console.WriteLine("Jelev salary: {0:F2} lv", Jelevsalary);
            Console.WriteLine("RoYaL salary: {0:F2} lv", RoYaLsalary);
            Console.WriteLine("Roli salary: {0:F2} lv", Rolisalary);
            Console.WriteLine("Trofon salary: {0:F2} lv", Trofonsalary);
            Console.WriteLine("Sino salary: {0:F2} lv", Sinosalary);
            Console.WriteLine("Others salary: {0:F2} lv", Othersalary);
        }
    }
}

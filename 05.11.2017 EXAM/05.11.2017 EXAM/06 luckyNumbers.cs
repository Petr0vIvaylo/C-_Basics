using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._11._2017_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int firstNumber = 1; firstNumber <= 9; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
                {
                    for (int thurdNumber = 1; thurdNumber <= 9; thurdNumber++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
                            
                                if (firstNumber + secondNumber == thurdNumber + fourth && number % (firstNumber + secondNumber)==0)
                                {

                                    Console.Write("{0}{1}{2}{3} ", firstNumber, secondNumber, thurdNumber, fourth);

                                }
                            
                                
                           
                            
                        }
                    }
                }
            }


        }
    }
}

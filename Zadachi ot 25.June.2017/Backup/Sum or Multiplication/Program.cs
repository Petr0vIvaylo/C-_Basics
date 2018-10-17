using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_or_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int numberInPut = int.Parse(Console.ReadLine());
            

            //double sum = 0;
            int first = 0 ;
                int second = 0;
                int thurd = 0;

                for (int one = 1; one <= numberInPut; one++)
            {
                for (int two = 1; two <= numberInPut; two++)
                {
                    for (int three = 1; three <= numberInPut; three++)
                    {


                        thurd += 1; 
                    }
                    second += 1;
                }
                first += 1;
            }

            if (first < second && second < thurd)
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", first, second, thurd, numberInPut);
            }
            else
            {
                Console.WriteLine("NO!");
            }


            
        }

    }
}






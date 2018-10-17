using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManiplationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
           
            double sum = 0;

            if (operation == '+')
            {
                string evenOrOdd;
                sum = numberOne + numberTwo;
                if (sum % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine("{0} + {1} = {2} - {3}", numberOne, numberTwo, sum, evenOrOdd);
            }

            else if (operation == '-')
            {
                string evenOrOdd;
                sum = Math.Abs(numberOne - numberTwo);
                if (sum % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine("{0} - {1} = {2} - {3}", numberOne, numberTwo, sum, evenOrOdd);
            }

            else if (operation == '*')
            {
                string evenOrOdd;
                sum = numberOne * numberTwo;
                if (sum % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine("{0} * {1} = {2} - {3}", numberOne, numberTwo, sum, evenOrOdd);
            }

            else if (operation == '/')
            {
                
                sum = numberOne / numberTwo;
                if (numberOne == 0 || numberTwo == 0)
                {
                    if (numberOne == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", numberTwo);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide {0} by zero", numberOne);
                    }
                }

                else if (numberOne != 0 && numberTwo != 0)
                {
                    Console.WriteLine("{0} / {1} = {2:F2}", numberOne, numberTwo, sum );
                } 
                
            

            }

            else if (operation == '%')
            {
                
                sum = numberOne % numberTwo;
                if (numberOne == 0 || numberTwo == 0)
                {
                    if (numberOne == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", numberTwo);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide {0} by zero", numberOne);
                    }
                }

                else if (numberOne != 0 && numberTwo != 0)
                {
                    

                    Console.WriteLine("{0} % {1} = {2}", numberOne, numberTwo, sum);
                }



            }
        }
    }
}

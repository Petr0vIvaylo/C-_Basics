using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            int paymentInMonths = int.Parse(Console.ReadLine());

            double percent = 0;
            double internetPayment = 0;
            double cost = 0;
            double totalSum = 0;
            if (contractPeriod == "one")
            {
                if (contractType == "Small")
                {
                    cost = 9.98;
                    if (internet == "yes")
                    {
                        internetPayment = 5.5;
                        totalSum = (cost + internetPayment) * paymentInMonths;
                    }
                    else
                    {
                        totalSum = cost  * paymentInMonths;
                    }
                    
                    
                }
                else if (contractType == "Middle")
                {
                    cost = 18.99;
                    if (internet == "yes")
                    {
                        internetPayment = 4.35;
                        totalSum = (cost + internetPayment) * paymentInMonths;
                    }
                    else
                    {
                        totalSum = cost * paymentInMonths;
                    }
                    
                }
                else if (contractType == "Large")
                {
                    cost = 25.98;
                    if (internet == "yes")
                    {
                        internetPayment = 4.35;
                        totalSum = (cost + internetPayment) * paymentInMonths;
                    }
                    else
                    {
                        totalSum = cost * paymentInMonths;
                    }
                    
                }
                else if (contractType == "ExtraLarge")
                {
                    cost = 35.99;
                    if (internet == "yes")
                    {
                        internetPayment = 3.85;
                        totalSum = (cost + internetPayment) * paymentInMonths;
                    }
                    else
                    {
                        totalSum = cost * paymentInMonths;
                    }
                    
                }
            }

            else if (contractPeriod == "two")
            {
                if (contractType == "Small")
                {
                    cost = 8.58;
                    if (internet == "yes")
                    {
                        internetPayment = 5.5;
                        percent = ((cost + internetPayment) * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }
                    else
                    {
                        percent = (cost * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }
                    
                }
                else if (contractType == "Middle")
                {
                    cost = 17.09;
                    if (internet == "yes")
                    {
                        
                        internetPayment = 4.35;
                        percent = ((cost + internetPayment) * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }
                    else
                    {
                        
                        percent = (cost * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }

                }
                else if (contractType == "Large")
                {
                    cost = 23.59;
                    if (internet == "yes")
                    {
                        
                        internetPayment = 4.35;
                        percent = ((cost + internetPayment) * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }
                    else
                    {
                        percent = (cost * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }

                    
                }
                else if (contractType == "ExtraLarge")
                {
                    cost = 31.79;
                    if (internet == "yes")
                    {
                        internetPayment = 3.85;
                        percent = ((cost + internetPayment) * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }
                    else
                    {
                        percent = (cost * paymentInMonths) * 0.0375;
                        totalSum = ((cost + internetPayment) * paymentInMonths) - percent;
                    }
                    
                }
            }

            Console.WriteLine("{0:F2} lv.", totalSum);
        }
    }
}

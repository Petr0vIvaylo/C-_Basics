using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cocktails
{
    class Cocktails
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orders = int.Parse(Console.ReadLine());

            double price =0;
            if (fruit == "Watermelon" && size == "small") 
            {                                                     
                price = (56 * 2) * orders;
            }
            else if (fruit == "Mango" && size == "small")
	        {
		        price = (36.66 * 2) * orders;
	        }

            else if (fruit == "Pineapple"&& size == "small" )
            {
                    price = (42.1 * 2) * orders;
            }
            else if (fruit == "Raspberry" && size == "small")
                {
                    price = (20 * 2) * orders;
                }
                
                
               
	        

            else
            {
                if (fruit == "Watermelon" && size == "big")
	                {
                        price = (28.7 * 5) * orders;
	                }
                else if (fruit == "Mango" && size == "big")
                {
                    price = (19.6 * 5) * orders;
                }
                else if (fruit =="Pineapple" && size == "big")
                {
                    price = (24.8 * 5) * orders;
                }
                else if (fruit =="Raspberry" && size == "big")
                {
                    price  = (15.2 * 5) * orders;
                }
                
                
                
            }
            double cocktailsPrice =price;
            
            if (cocktailsPrice > 1000)
            {
                 cocktailsPrice /= 2;
                Console.WriteLine("{0:F2} lv.", cocktailsPrice);
            }
            else if (cocktailsPrice >=400 && cocktailsPrice <=1000)
            {
                cocktailsPrice =cocktailsPrice -(cocktailsPrice * 0.15);
                Console.WriteLine("{0:F2} lv.", cocktailsPrice);
            }
            else
            {
                
                Console.WriteLine("{0:F2} lv.", cocktailsPrice);
            }
            
        }
    }
}

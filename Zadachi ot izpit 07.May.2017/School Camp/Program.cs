using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            double numberOFStudents = double.Parse(Console.ReadLine());
            double numberOfNights = double.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sport= "a";
            //1.	Сезонът – текст - “Winter”, “Spring” или “Summer”;
           // 2.	Видът на групата – текст - “boys”, “girls” или “mixed”;
            
            if (season == "Winter" )
	        {
                if ( groupType == "boys"  )
                {
                     pricePerNight = 9.6;
                     sport = "Judo";
                }
                    else if (groupType == "girls")
                {
                     pricePerNight = 9.6;
                         sport = "Gymnastics";
                }
                else if (groupType == "mixed")
                {
                     pricePerNight = 10;
                     sport = "Ski";
                }
                
		        
	        }
            else if (season == "Spring")
            {
                if ( groupType == "boys" )
                {
                     pricePerNight = 7.2;
                     sport = "Tennis";
                }
                else if (groupType == "girls")
                {
                     pricePerNight = 7.2;
                         sport = "Athletics";
                }
                else if (groupType == "mixed")
                {
                     pricePerNight = 9.5;
                     sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys"  )
                {
                     pricePerNight = 15;
                     sport = "Football";
                }
                else if (groupType == "girls")
                {
                     pricePerNight = 15;
                     sport = "Volleyball";
                }
                else if (groupType == "mixed")
                {
                     pricePerNight = 20;
                     sport = "Swimming";
                }
            }
            double priceForAllNights=0;
            if (numberOFStudents >= 50)
            {
                 priceForAllNights = (pricePerNight * numberOFStudents * numberOfNights) *0.5;
            }
            else if (numberOFStudents >= 20 && numberOFStudents < 50)
            {
                 priceForAllNights = (pricePerNight * numberOFStudents * numberOfNights)-(pricePerNight * numberOFStudents * numberOfNights) *0.15;
            }
            else if (numberOFStudents >=10 && numberOFStudents < 20)
            {
                 priceForAllNights = (pricePerNight * numberOFStudents * numberOfNights)-(pricePerNight * numberOFStudents * numberOfNights) *0.05;
            }
            else if (numberOFStudents < 10 )
            {
                priceForAllNights = (pricePerNight * numberOFStudents * numberOfNights);
            }

            Console.WriteLine("{0} {1:F2} lv.", sport, priceForAllNights);
        }
    }
}

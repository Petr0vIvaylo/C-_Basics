using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_On_Time_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examStartHour = int.Parse(Console.ReadLine());
            int examStartMinutes = int.Parse(Console.ReadLine());
            int examArrivalHour = int.Parse(Console.ReadLine());
            int examArrivalMinute = int.Parse(Console.ReadLine());

            int diffTotalMinutes = (examArrivalHour * 60 + examArrivalMinute) - (examStartHour * 60 + examStartMinutes);
            int diffHours = Math.Abs(diffTotalMinutes / 60);
            int diffMinutes = Math.Abs(diffTotalMinutes % 60);

            if (diffTotalMinutes > 0)
            {
                Console.WriteLine("Late"); 
            }
            else if (diffTotalMinutes >= -30)
            {
                Console.WriteLine("On time"); 
            }
            else
            {
                Console.WriteLine("Early");
            }

            if (diffTotalMinutes >= 60)
            {
                Console.WriteLine("{0}:{1} hours after the start", diffHours, diffMinutes);
            }
            else if (diffTotalMinutes > 0)
            {
                Console.WriteLine("{0} minutes after the start", diffMinutes); 
            }

            if (diffTotalMinutes <= -60)
            {
                Console.WriteLine("{0}:{1} hours before the start", diffHours, diffMinutes);
            }
            else if (diffTotalMinutes < 0)
            {
                Console.WriteLine("{0} minutes before the start", diffMinutes);
            }




        }
    }
}

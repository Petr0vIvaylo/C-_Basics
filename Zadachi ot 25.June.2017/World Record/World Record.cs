using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());


            double swimingSeconds = distance * timeInSeconds;
            double waterResistance = Math.Floor((distance / 15) );
            waterResistance *= 12.5;
            double totalTime = waterResistance + swimingSeconds;


            if (recordSeconds <= totalTime)
            {
                double diff = (totalTime - recordSeconds  );
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", diff);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
            }

        }
    }
}

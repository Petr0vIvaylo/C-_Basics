using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForBoilingRakia = int.Parse(Console.ReadLine());

            double litriRakiaSum = 0;
            double gradusRakia = 0;


            for (int i = 0; i < daysForBoilingRakia; i++)
            {
                double litersRakia = double.Parse(Console.ReadLine());
                double gradus = double.Parse(Console.ReadLine());

                litriRakiaSum += litersRakia;
                gradusRakia += litersRakia * gradus;

            }
            double gradusTotal = gradusRakia / litriRakiaSum;

            Console.WriteLine("Liter: {0:F2}" , litriRakiaSum);
            Console.WriteLine("Degrees: {0:F2}" , gradusTotal);

            if (gradusTotal < 38 )
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (gradusTotal >=38 && gradusTotal <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (gradusTotal > 42 )
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}

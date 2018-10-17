using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.September._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfTables = double.Parse(Console.ReadLine());
            double lenghtOfTable = double.Parse(Console.ReadLine());
            double widthOfTable = double.Parse(Console.ReadLine());

            double dollar = 1.85;

            double sizeOfPokrivka = numberOfTables * (lenghtOfTable + 2 * 0.3) * (widthOfTable + 2 * 0.3);
            double sizeOfKareta = numberOfTables * (lenghtOfTable / 2) * (lenghtOfTable / 2);

            double costOfCloth = sizeOfPokrivka * 7 + sizeOfKareta * 9;
            double costInLeva = costOfCloth * dollar;

            Console.WriteLine("{0:F2} USD", costOfCloth);
            Console.WriteLine("{0:F2} BGN", costInLeva);

        }
    }
}

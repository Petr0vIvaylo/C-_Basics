using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_of_spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double nuberOfTurns = double.Parse(Console.ReadLine());
            double numberPerTurn = double.Parse(Console.ReadLine());



            for (int i = 0; i < nuberOfTurns; i++)
            {
                double numberInput = double.Parse(Console.ReadLine());

                if (numberInput > 0 && numberInput < 9)
                {
                    numberInput = numberInput * 0.2;
                }

            }



        }
    }
}

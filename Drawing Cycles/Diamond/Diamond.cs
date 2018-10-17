using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stars = 0;
            //firstLine
            if (n % 2 ==0 )
            {
                stars = 2;

                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string ('*' ,stars));
                Console.WriteLine(new string('-', (n - 2) / 2));
            }
            else
            {
                stars = 1;
                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', (n - stars) / 2));
            }

            int dashesInMiddle = 0;
            if (n % 2 == 0)
            {

                dashesInMiddle = 2;
            }
            else
            {
                dashesInMiddle = 1;
            }
            int numberOfRows = (n - 1) / 2;
            for (int i = 0; i < numberOfRows; i++)
            {
                int dashesInEnd = (n - 2 - dashesInMiddle) / 2;
                Console.Write(new string ('-' , dashesInEnd));
                Console.Write("*");
                Console.Write(new string('-', dashesInMiddle));
                Console.Write("*");
                Console.WriteLine(new string('-', dashesInEnd));
                dashesInMiddle += 2;
            }
            numberOfRows--;
            dashesInMiddle -= 2;
            for (int i = numberOfRows-1 ; i >= 0; i--)
            {
                dashesInMiddle -= 2;
                int dashesInEnd = (n - 2 - dashesInMiddle) / 2;
                Console.Write(new string('-', dashesInEnd));
                Console.Write("*");
                Console.Write(new string('-', dashesInMiddle));
                Console.Write("*");
                Console.WriteLine(new string('-', dashesInEnd));
                
            }

            //lastLine
            if (n % 2 == 0)
            {
                stars = 2;

                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', (n - 2) / 2));
            }
            else
            {
                stars = 1;
                Console.Write(new string('-', (n - stars) / 2));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', (n - stars) / 2));
            }
        }
    }
}

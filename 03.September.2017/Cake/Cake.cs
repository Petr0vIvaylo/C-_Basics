using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int cakeArea = cakeWidth * cakeLength;


            for (int i = cakeArea; i > 0; i--)
            {  
                char n = char.Parse(Console.ReadLine());
               // string stop = Console.ReadLine();

                if (cakeArea > 0 )
                {
                    cakeArea -= n;
                   
                }
                else 
                {

                }
            }
            

        }
    }
}

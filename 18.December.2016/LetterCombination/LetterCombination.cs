using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombination
{
    class LetterCombination
    {
        static void Main(string[] args)
        {
            

                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());
                char thurdLetter = char.Parse(Console.ReadLine());
                

                double sum = 0;


                for (char first = 'a'; first <= firstLetter; first++)
                {
                
                    for (char second = 'a'; second <= secondLetter; second++)
                    {
                    
                        for (char thurd = 'a'; thurd <= thurdLetter; thurd++)
                        {

                        Console.Write(thurd);
                        Console.WriteLine();
                             sum += 1;







                    }

                    }

                }
                Console.WriteLine("{0}", sum - 1);
            }

        }
    }





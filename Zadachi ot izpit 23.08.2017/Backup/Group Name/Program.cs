using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine().ToUpper());
            char secondLetter = char.Parse(Console.ReadLine());
            char thurdLetter = char.Parse(Console.ReadLine());
            char fourtLetter = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            double sum = 0;


            for (char first = 'A'; first <= firstLetter; first ++)
            {
                for (char second = 'a'; second <= secondLetter; second++)
                {
                    for (char thurd = 'a'; thurd <= thurdLetter; thurd++)
                    {
                        for (char fourt = 'a'; fourt <= fourtLetter; fourt++)
                        {
                            for (int num = 0; num <= number; num++)
                            {

                                sum += 1; 
                            }
                            
                        }
                        
                    }
                    
                }
                
            }
            Console.WriteLine("{0}", sum-1);
        }

    }
}

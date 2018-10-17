using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int vowelSum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                switch (currentLetter)
                {
                    case 'a': vowelSum += 1; break;
                    case 'e': vowelSum += 2; break;
                    case 'i': vowelSum += 3;break;
                    case 'o': vowelSum += 4;break;
                    case 'u': vowelSum += 5; break;
                    default:
                        break;
                }
            }
            Console.WriteLine(vowelSum);
        }

    }
}

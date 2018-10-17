using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                
                for (int j = i+1; j <= m; j++)
                {
                    
                    for (int k = j+1; k <= m; k++)
                    {
                        
                        for (int l = k+1; l <= m; l++)
                        {
                            Console.WriteLine("{0} {1} {2} {3}",i,j,k,l);
                            count++;
                        }
                        
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

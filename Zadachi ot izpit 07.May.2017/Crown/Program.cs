using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("@");
            Console.Write(new string(' ', n - 2));
            Console.Write("@");
            Console.Write(new string(' ', n - 2));
            Console.Write("@");
            Console.WriteLine();


            //Console.Write("**");
            //Console.Write(new string(' ', n - 3));
            //Console.Write("*");
            //Console.Write(new string(' ', n - 3));
            //Console.Write("**");
            //Console.WriteLine();


            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("*");
                for (int col = 0; col < row; col++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                
                
                    for (int i = 0; i < (n/2) - 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                    for (int i = 0; i < (n / 2) - 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                   
                        for (int i = 0; i < 1; i++)
                        {
                            for (int j = 0; j < row; j++)
                            {
                                Console.Write(".");
                            }
                            Console.Write(".");
                        }
                        
                  

                    Console.Write("*");
                    Console.WriteLine();
                
                
            }
            
           

                    
            }
            
        }
    }

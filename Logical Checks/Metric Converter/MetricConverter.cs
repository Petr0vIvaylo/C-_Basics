using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            string edinicaVhod = Console.ReadLine();
            string edinicaIzhod = Console.ReadLine();
            
            switch (edinicaVhod)
            {
                case "m":; break;
                case "mm": number /= 1000; break;
                case "cm": number /= 100; break;
                case "mi": number /= 0.000621371192; break;
                case "in": number /= 39.3700787; break;
                case "km": number /= 0.001; break;
                case "ft": number /= 3.2808399; break;
                case "yd": number /= 1.0936133; break;
                
                default:
                    break;
            }
            switch (edinicaIzhod)
            {
                case "m": number *=  1; break;
                case "mm": number *= 1000; break;
                case "cm": number *= 100; break;
                case "mi": number *= 0.000621371192; break;
                case "in": number *= 39.3700787; break;
                case "km": number *= 0.001; break;
                case "ft": number *= 3.2808399; break;
                case "yd": number *= 1.0936133; break;
                
                default:
                    break;
            }


            Console.WriteLine(number);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.July._2016
{
    class Money
    {
        static void Main(string[] args)
        {
            double bitCoins = double.Parse(Console.ReadLine());
            double UAN = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitCoin = 1168;
            double chinaUAN = 0.15;
            double dollar = 1.76;
            double EUR = 1.95;

            double bitCoinSum = bitCoins * bitCoin;
            double UANSum = (UAN * chinaUAN) * dollar;
            double moneyInEUR = (bitCoinSum + UANSum)/ EUR  ;
            double moneyAfterTax = moneyInEUR - moneyInEUR * commision / 100;
            Console.WriteLine("{0:F2}",moneyAfterTax );

        }
    }
}

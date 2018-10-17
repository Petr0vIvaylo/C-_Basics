using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            decimal bitCoini = decimal.Parse(Console.ReadLine());
            decimal kitaiskiUAN = decimal.Parse(Console.ReadLine());
            decimal commision = decimal.Parse(Console.ReadLine());
            
            decimal bitcoinValue = 1168m;
            decimal uanValue = 0.15m;
            decimal dollarValue = 1.76m;
            decimal eurValue = 1.95m;

           decimal bitCoin = bitcoinValue * bitCoini;
            decimal uan = (kitaiskiUAN * uanValue)*dollarValue;
            commision = commision / 100;

            decimal sum = (bitCoin + uan)/eurValue;
            decimal totalSum = sum * commision;
            decimal finalSum = sum - totalSum;
            Console.WriteLine("{0:F2}",finalSum);
        }
    }
}

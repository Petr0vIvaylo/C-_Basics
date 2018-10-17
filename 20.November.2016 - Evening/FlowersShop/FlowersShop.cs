using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop
{
    class FlowersShop
    {
        static void Main(string[] args)
        {
            double magnolii = double.Parse(Console.ReadLine());    
            double zumbiuli = double.Parse(Console.ReadLine());
            double roses = double.Parse(Console.ReadLine());
            double kaktus = double.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double magnoliiPrice = 3.25;
            double zumbiuliPrice = 4;
            double rosesPrice = 3.5;
            double kaktusPrice = 8;

            double flowersSum = magnolii * magnoliiPrice + zumbiuli * zumbiuliPrice + roses * rosesPrice
                + kaktus * kaktusPrice;

            double sumAfterTaxes = flowersSum - flowersSum * 0.05;
            if (sumAfterTaxes >=priceOfGift)
            {
                double moneyLeft =Math.Floor(sumAfterTaxes - priceOfGift);
                Console.WriteLine("She is left with {0} leva.", moneyLeft);
            }
            else
            {
                double moneyLeft = Math.Ceiling(priceOfGift - sumAfterTaxes);

                Console.WriteLine("She will have to borrow {0} leva.", moneyLeft);

            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Picture
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPictures = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string typeOfOrder = Console.ReadLine();

            double pictureCost = 0;

            if (type == "9X13")
            {
                 pictureCost = numberOfPictures * 0.16;
                if (numberOfPictures >= 50 )
                {
                     pictureCost = (0.16 * numberOfPictures) - (0.16 * numberOfPictures) * 0.05;
                }
            }

            else if (type == "10X15")
            {
                pictureCost = numberOfPictures * 0.16;
                if (numberOfPictures >= 80)
                {
                     pictureCost = (0.16 * numberOfPictures) - (0.16 * numberOfPictures) * 0.03;
                }
            }

            else if (type == "13X18")
            {
                 pictureCost = numberOfPictures * 0.38;
                if (numberOfPictures >= 50  && numberOfPictures <= 100)
                {
                     pictureCost = (0.38 * numberOfPictures) - (0.38 * numberOfPictures) * 0.03;
                }
                else if (numberOfPictures > 100)
                {
                     pictureCost = (0.38 * numberOfPictures) - (0.38 * numberOfPictures) * 0.05;
                }
            }

            else if (type == "20X30")
            {
                 pictureCost = numberOfPictures * 2.9;
                if (numberOfPictures >= 10 && numberOfPictures <= 50)
                {
                     pictureCost = (2.9 * numberOfPictures) - (2.9 * numberOfPictures) * 0.07;
                }
                else if (numberOfPictures > 50)
                {
                     pictureCost = (2.9 * numberOfPictures) - (2.9 * numberOfPictures) * 0.09;
                }
            }

            if (typeOfOrder == "online" )
            {
                double finalDiscount = pictureCost - (pictureCost * 0.02);
                Console.WriteLine("{0:F2}BGN" , finalDiscount);
            }
            else
            {
                Console.WriteLine("{0:F2}BGN" , pictureCost);
            }

        }
    }
}

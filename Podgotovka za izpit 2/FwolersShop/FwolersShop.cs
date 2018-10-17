using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FwolersShop
{
    class FwolersShop
    {
        static void Main(string[] args)
        {

            double hrizantemi = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double laleta = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string praznik= Console.ReadLine().ToUpper();

            double hrizantemiPrice = 0;
            double roziPrice = 0;
            double laletaPrice = 0;
            double counterFwolers = hrizantemi + rozi + laleta;

            if (season == "Spring" || season == "Summer")
            {
                hrizantemiPrice = 2;
                roziPrice = 4.1;
                laletaPrice = 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                hrizantemiPrice = 3.75;
                roziPrice = 4.5;
                laletaPrice = 4.15;
            }

            double buket = (hrizantemi * hrizantemiPrice) +
                                (rozi * roziPrice) +
                                (laleta * laletaPrice);
            if (praznik == "Y")
            {
                buket = buket + (buket * 0.15);
            }

            if (laleta > 7 && season == "Spring")
            {
                buket = buket - (buket * 0.05);
            }
            if (rozi >= 10 && season == "Winter")
            {
                buket = buket - (buket * 0.1);
            }
            if (counterFwolers > 20 )
            {
                buket = buket - (buket * 0.2);
            }
            Console.WriteLine("{0:f2}", buket+2);
        }
    }
}

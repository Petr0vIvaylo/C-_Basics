using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int monts = int.Parse(Console.ReadLine());
            double electrycityBill = 0;
            double sum = 0;
            double others = 0;
            for (int i = 0; i < monts; i++)
            {
                 electrycityBill = double.Parse(Console.ReadLine());
                sum+=electrycityBill;
                others += (electrycityBill + 20 + 15) + (electrycityBill + 20 + 15) * 0.2;
            }

            double water = monts * 20;
            double internet = monts * 15;
            double monthlyAerage = (sum + water + internet + others) / monts;


            Console.WriteLine("Electricity: {0:F2} lv",sum);
            Console.WriteLine("Water: {0:F2} lv",water);
            Console.WriteLine("Internet: {0:F2} lv",internet);
            Console.WriteLine("Other: {0:F2} lv",others);
            Console.WriteLine("Average: {0:F2} lv",monthlyAerage);
            //double totalelectrycityBill = 


        }
    }
}

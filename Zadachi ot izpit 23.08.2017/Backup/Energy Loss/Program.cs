using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfTrainingDays = double.Parse(Console.ReadLine());
            double numberOfDancers = double.Parse(Console.ReadLine());

            double trainingHours;
            double energySum = 0;

            

           for (int i = 1; i <= numberOfTrainingDays; i++)
           {
                trainingHours = double.Parse(Console.ReadLine());
                

               if (i % 2 == 0 && trainingHours % 2 == 0)
                {
                  double energyLoss = 68;
                   double energy1 = numberOfDancers * energyLoss;
                   energySum += energy1;
                }

               else if (i % 2 != 0 && trainingHours % 2 != 0)
                {
                 double energyLoss = 30;
                 double energy4 = numberOfDancers * energyLoss;
                 energySum += energy4;
                }
               else if (i % 2 != 0 && trainingHours % 2 == 0)
               {
                   double energyLoss = 49;
                   double energy2 = numberOfDancers * energyLoss;
                   energySum += energy2;
               }

               else if (i % 2 == 0 && trainingHours % 2 != 0)
               {
                   double energyLoss = 65;
                   double energy3 = numberOfDancers * energyLoss;
                   energySum += energy3;
               }

               



             }

           double totalEnergy = 100 * numberOfDancers * numberOfTrainingDays;
           double unusedEnergy = totalEnergy - energySum;
           double energyLeft = unusedEnergy / numberOfDancers / numberOfTrainingDays;

           if (energyLeft <= 50)
           {
               Console.WriteLine( "They are wasted! Energy left: {0:F2}"     ,  energyLeft);
           }
           else
           {
               Console.WriteLine("They feel good! Energy left: {0:F2} "    ,  energyLeft);
           }

           

            
        }
    }
}

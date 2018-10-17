using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            double period= double.Parse(Console.ReadLine());

            double patientsMaintained = 7;
            double untreatedPatients = 0;
            double patientsTreated = 0;

            for (int i = 1; i <= period; i++)
            {
                double numberOfPatients = double.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > patientsMaintained)
                {
                    patientsMaintained += 1;
                    patientsTreated += patientsMaintained;
                    untreatedPatients += Math.Abs(patientsMaintained - numberOfPatients);

                }
                else if (patientsMaintained <= numberOfPatients)
                {
                    patientsTreated += patientsMaintained;
                    untreatedPatients += Math.Abs(patientsMaintained - numberOfPatients);
                    
                }
                

            }
            Console.WriteLine(patientsTreated);
            Console.WriteLine(untreatedPatients);

        }
    }
}

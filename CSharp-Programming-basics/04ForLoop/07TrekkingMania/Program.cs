using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int groupsOfPeople = int.Parse(Console.ReadLine());

            double gr1 = 0;
            double gr2 = 0;
            double gr3 = 0;
            double gr4 = 0;
            double gr5 = 0;

            for (int i = 1; i <= groupsOfPeople; i++)
            {
                double climbers = double.Parse(Console.ReadLine());

                if (climbers <= 5)
                {
                    gr1 += climbers;
                }
                else if (climbers <= 12)
                {
                    gr2 += climbers;
                }
                else if (climbers <= 25)
                {
                    gr3 += climbers;
                }
                else if (climbers <= 40)
                {
                    gr4 += climbers;
                }
                else
                {
                    gr5 += climbers;
                }
            }

            double totalClimbers = gr1 + gr2 + gr3 + gr4 + gr5;

            gr1 = gr1 / totalClimbers * 100;
            gr2 = gr2 / totalClimbers * 100;
            gr3 = gr3 / totalClimbers * 100;
            gr4 = gr4 / totalClimbers * 100;
            gr5 = gr5 / totalClimbers * 100;

            Console.WriteLine($"{gr1:f2}%");
            Console.WriteLine($"{gr2:f2}%");
            Console.WriteLine($"{gr3:f2}%");
            Console.WriteLine($"{gr4:f2}%");
            Console.WriteLine($"{gr5:f2}%");


        }
    }
}

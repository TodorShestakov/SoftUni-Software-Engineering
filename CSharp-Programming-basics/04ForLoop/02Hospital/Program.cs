using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int nepregledani = 0;
            int pregledani = 0;

            for (int i = 1; i <= period; i++)
            {
                int numberOfPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (nepregledani > pregledani)
                    {
                        doctors++;
                    }

                }

                if (numberOfPatients > doctors)
                {
                    pregledani += doctors;
                    nepregledani += numberOfPatients - doctors;
                }

                else
                {
                    pregledani += numberOfPatients;
                }
            }

            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {nepregledani}.");
        }
    }
}

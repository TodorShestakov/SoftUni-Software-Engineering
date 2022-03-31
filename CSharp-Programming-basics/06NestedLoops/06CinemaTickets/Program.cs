using System;

namespace _6._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int totalStudnets = 0;
            int totalStandrds = 0;
            int totalKids = 0;
            int totalTickets = 0;

            while (comand != "Finish")
            {
                int students = 0;
                int standard = 0;
                int kid = 0;

                int freeSpots = int.Parse(Console.ReadLine());

                for (int i = 0; i < freeSpots; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            students++;
                            break;
                        case "standard":
                            standard++;
                            break;
                        case "kid":
                            kid++;
                            break;
                    }
                }
                totalStudnets += students;
                totalStandrds += standard;
                totalKids += kid;
                double percentageFull = (students + standard + kid) / (double)freeSpots * 100;
                Console.WriteLine($"{comand} - {percentageFull:f2}% full.");

                comand = Console.ReadLine();
            }
            totalTickets = totalStudnets + totalStandrds + totalKids;
            Console.WriteLine($"Total tickets: {totalTickets}");
            double standartsPercentage = totalStandrds / (double) totalTickets * 100;
            double studentsPercentage = totalStudnets / (double) totalTickets * 100;
            double kidsPercentage = totalKids / (double) totalTickets * 100;

            Console.WriteLine($"{studentsPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartsPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidsPercentage:f2}% kids tickets.");
        }
    }
}

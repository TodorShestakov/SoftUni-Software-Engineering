using System;

namespace _5._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numOfWorkersWorkingOverTime = int.Parse(Console.ReadLine());

            double work = (days * 0.9) * 8;
            double workOverTime = numOfWorkersWorkingOverTime * 2 * days;

            double totalWork = Math.Floor(work + workOverTime);

            double difference = Math.Abs(totalWork - neededHours);

            if (totalWork >= neededHours)
            {
                Console.WriteLine($"Yes!{difference} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{difference} hours needed.");
            }
        }
    }
}

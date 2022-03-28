using System;

namespace _8._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfRows = int.Parse(Console.ReadLine());

            int maxN = int.MinValue;
            int minN = int.MaxValue;

            for (int i = 0; i < numberOfRows; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > maxN)
                {
                    maxN = num;
                }
                if (num < minN)
                {
                    minN = num;
                }
            }

           Console.WriteLine("Max number: " + maxN);
           Console.WriteLine("Min number: " + minN);

        }
    }
}

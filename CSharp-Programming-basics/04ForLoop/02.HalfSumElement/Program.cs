using System;

namespace _2._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                sum += numbers;
                if (numbers > max)
                {
                    max = numbers;
                }
            }

            int sumWithoutMax = sum - max;

            if (sumWithoutMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int difference = Math.Abs(sumWithoutMax - max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }
        }
    }
}

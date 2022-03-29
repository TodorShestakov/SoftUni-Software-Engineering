using System;

namespace _5._While_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();


            int maxN = int.MinValue;

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum > maxN)
                {
                    maxN = currentNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxN);
        }
    }
}

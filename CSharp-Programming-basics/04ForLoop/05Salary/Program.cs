using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {


            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int penalty = 0;

            for (int i = 1; i <= openTabs; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    penalty = 150;
                    salary -= penalty;

                }
                else if (website == "Instagram")
                {
                    penalty = 100;
                    salary -= penalty;

                }
                else if (website == "Reddit")
                {
                    penalty = 50;
                    salary -= penalty;

                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }

            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }


        }
    }
}

using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            int yearsToLive = int.Parse(Console.ReadLine());

            double age = 18;

            for (int i = 1800; i <= yearsToLive; i++)
            {
                if (i % 2 == 0)
                {
                    age++;
                    money -= 12000;
                }
                else
                {

                    money -= 12000 + age * 50;
                    age++;
                }
            }


            double diff = Math.Abs(0 - money);

            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:f2} dollars to survive.");
            }
        }
    }
}

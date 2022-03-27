using System;

namespace _2._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {           
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;

            switch (city)
            {
                case "Sofia":
                    if (sales <= 500 && sales >= 0)
                    {
                        commission = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 0.07;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        commission = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    break;
            }

            switch (city)
            {
                case "Varna":
                    if (sales <= 500 && sales >= 0)
                    {
                        commission = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        commission = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    break;
            }

            switch (city)
            {
                case "Plovdiv":
                    if (sales <= 500 && sales >= 0)
                    {
                        commission = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (sales > 1000 & sales <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    break;
            }

            double total = sales * commission;

            if (total != 0)
            {
                Console.WriteLine($"{total:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}

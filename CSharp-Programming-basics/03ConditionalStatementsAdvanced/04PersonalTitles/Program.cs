using System;

namespace _3._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR 1
            //double age = double.Parse(Console.ReadLine());
            //string gender = Console.ReadLine();

            //if (gender == "f")
            //{
            //    if (age < 16)
            //    {
            //        Console.WriteLine("Miss");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ms.");
            //    }
            //}
            //else
            //{
            //    if (age < 16)
            //    {
            //        Console.WriteLine("Master");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mr.");
            //    }
            //}

            //VAR 2 

            //double age = double.Parse(Console.ReadLine());
            //string gender = Console.ReadLine();

            //if (gender == "f" && age <16)
            //{
            //    Console.WriteLine("Miss");
            //}
            //else if (gender == "f" && age >= 16)
            //{
            //    Console.WriteLine("Ms.");
            //}
            //else if (gender == "m" && age < 16)
            //{
            //    Console.WriteLine("Master");
            //}
            //else if (gender == "m" && age >= 16)
            //{
            //    Console.WriteLine("Mr.");
            //}

            //VAR 3
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "f" when age < 16:
                    Console.WriteLine("Miss");
                    break;
                case "f" when age >= 16:
                    Console.WriteLine("Ms.");
                    break;
                case "m" when age < 16:
                    Console.WriteLine("Master");
                    break;
                case "m" when age >= 16:
                    Console.WriteLine("Mr.");
                    break;
            }
        }
    }
}

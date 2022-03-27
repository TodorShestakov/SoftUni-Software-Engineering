using System;

namespace _1._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

//VAR 1
            //string name = Console.ReadLine();
            //int rows = int.Parse(Console.ReadLine());
            //int columns = int.Parse(Console.ReadLine());

            //int capacity = rows * columns;

            //double price = 0;

            //if (name == "Premiere")
            //{
            //    price = 12.00;
            //}
            //else if (name == "Normal")
            //{
            //    price = 7.50;
            //}
            //else if (name == "Discount")
            //{
            //    price = 5.00;
            //}

            //double total = price * capacity;

            //Console.WriteLine($"{total:f2} leva");



//VAR 2
            string name = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int capacity = rows * columns;

            double price = 0;

            switch (name)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
            }

            double total = price * capacity;

            Console.WriteLine($"{total:f2} leva");


        }
    }
}

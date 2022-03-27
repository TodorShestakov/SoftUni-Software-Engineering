using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
//VAR 1
            //string fruit = Console.ReadLine();
            //string day = Console.ReadLine();
            //double quantity = double.Parse(Console.ReadLine());
            //double price = 0;

            //switch (day)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Wednesday":
            //    case "Thursday":
            //    case "Friday":
            //        if (fruit == "banana")
            //        {
            //            price = 2.50;
            //        }
            //        else if (fruit == "apple")
            //        {
            //            price = 1.20;
            //        }
            //        else if (fruit == "orange")
            //        {
            //            price = 0.85;
            //        }
            //        else if (fruit == "grapefruit")
            //        {
            //            price = 1.45;
            //        }
            //        else if (fruit == "kiwi")
            //        {
            //            price = 2.70;
            //        }
            //        else if (fruit == "pineapple")
            //        {
            //            price = 5.50;
            //        }
            //        else if (fruit == "grapes")
            //        {
            //            price = 3.85;
            //        }
            //        else
            //        {
            //            Console.WriteLine("");
            //        }
            //       break;  

            //    case "Saturday":
            //    case "Sunday":
            //        if (fruit == "banana")
            //        {
            //            price = 2.70;
            //        }
            //        else if (fruit == "apple")
            //        {
            //            price = 1.25;
            //        }
            //        else if (fruit == "orange")
            //        {
            //            price = 0.90;
            //        }
            //        else if (fruit == "grapefruit")
            //        {
            //            price = 1.60;
            //        }
            //        else if (fruit == "kiwi")
            //        {
            //            price = 3.00;
            //        }
            //        else if (fruit == "pineapple")
            //        {
            //            price = 5.60;
            //        }
            //        else if (fruit == "grapes")
            //        {
            //            price = 4.20;
            //        }
            //        else
            //        {
            //            Console.WriteLine("");
            //        }
            //        break;

            //}

            //double total = quantity * price;
            //if (total != 0)
            //{
            //    Console.WriteLine($"{total:f2}");
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

//VAR 2
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            double total = price * quantity;

            if (total != 0)
            {
                Console.WriteLine($"{total:f2}");
            }           
        }
    }
}

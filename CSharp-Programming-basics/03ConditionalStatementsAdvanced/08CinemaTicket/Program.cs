using System;

namespace _8.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
//VAR 1
            //string weekDay = Console.ReadLine();

            //int price = 0;

            //switch (weekDay)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //        price = 12;
            //        break;
            //    case "Wednesday":
            //    case "Thursday":
            //        price = 14;
            //        break;
            //    case "Friday":
            //        price = 12;
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        price = 16;
            //        break;
            //}

            //Console.WriteLine(price);

//VAR 2
            ////Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
            ////12       12        14      14          12      16         16
            
            string weekDay = Console.ReadLine();

            if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (weekDay == "Wednesday" || weekDay == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (weekDay == "Saturday" || weekDay == "Sunday")
            {
                Console.WriteLine(16);
            }

        }
    }
}

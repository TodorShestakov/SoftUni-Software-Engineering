using System;

namespace Nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hour:d2}:{min:d2}");  // :d2 показва 0 преди часовете и минутите не е включено в условието на задачата
                }
            }

            //for (int day = 1; day <= 31; day++)
            //{
            //    Console.WriteLine($"{day}.10.2021");
            //    for (int hour = 0; hour <= 23; hour++)
            //    {
            //        for (int min = 0; min <= 59; min++)
            //        {
            //            for (int sec = 0; sec <= 59; sec++)
            //            {
            //                Console.WriteLine($"{hour} : {min} : {sec}");
            //            }
            //        }
            //    }
            //}
        }
    }
}

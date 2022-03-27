using System;

namespace T
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int hour = 0;
            int minutes = 0;
            int difference = 0;

            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;

            if (arrivalMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                difference = Math.Abs(arrivalMinutes - examMinutes);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalMinutes < examMinutes - 30)
            {
                Console.WriteLine("Early");
                difference = Math.Abs(arrivalMinutes - examMinutes);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine($"On time");
                difference = Math.Abs(examMinutes - arrivalMinutes);
                Console.WriteLine($"{difference} minutes before the start");
            }

        }
    }
}

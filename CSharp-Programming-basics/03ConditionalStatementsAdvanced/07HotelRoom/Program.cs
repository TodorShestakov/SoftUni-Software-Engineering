using System;

namespace _7._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            
            double studioPrice = 0;
            double apartmentPrice = 0;
            double totalPriceStudio = 0;
            double totalPriceApartment = 0;

            if ((month == "May") || (month == "October"))
            {
                studioPrice = 50;
                apartmentPrice = 65;
                totalPriceStudio = nightsCount * studioPrice;
                totalPriceApartment = nightsCount * apartmentPrice;
                if (nightsCount > 7 && nightsCount <= 14)
                {
                    totalPriceStudio *= 0.95;
                }
                else if (nightsCount > 14)
                {
                    totalPriceStudio *= 0.70;
                }
            }
            else if ((month == "June") || (month == "September"))
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                totalPriceStudio = nightsCount * studioPrice;
                totalPriceApartment = nightsCount * apartmentPrice;
                if (nightsCount > 14)
                {
                    totalPriceStudio *= 0.80;
                }
            }
            else if ((month == "July") || (month == "August"))
            {
                studioPrice = 76;
                apartmentPrice = 77;
                totalPriceStudio = nightsCount * studioPrice;
                totalPriceApartment = nightsCount * apartmentPrice;
            }

            if (nightsCount > 14)
            {
                totalPriceApartment *= 0.90;
            }

            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");

        }
    }
}

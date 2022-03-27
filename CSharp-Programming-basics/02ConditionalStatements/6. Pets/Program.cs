using System;

namespace _6._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – брой дни – цяло число в интервал[1…5000]
            //•	Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]


            int days = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            double totalFoodLeft = dogFoodPerDay + catFoodPerDay + turtleFoodPerDay;

            double dogEats = dogFoodPerDay * days;
            double catEats = catFoodPerDay * days;
            double turtleEats = (turtleFoodPerDay / 1000) * days;

            double totalEaten = dogEats + catEats + turtleEats;

            double difference = Math.Abs(totalEaten - foodLeftKg);

            if (totalEaten <= foodLeftKg)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }
        }
    }
}

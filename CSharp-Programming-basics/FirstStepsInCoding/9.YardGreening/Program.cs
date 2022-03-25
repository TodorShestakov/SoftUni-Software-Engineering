using System;

namespace _9.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());
            
            double totalPrice = m2 * 7.61;
            double discount = totalPrice * 0.18;  
            
            Console.WriteLine($"The final price is: {totalPrice-discount} lv."); 
            Console.WriteLine($"The discount is: {discount} lv.");
        }	

    }
}

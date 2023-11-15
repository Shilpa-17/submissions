using System;

namespace que2
{
    class Multiplication
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = 5;
            int range = 10;
            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= range; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }



        }
    }
}
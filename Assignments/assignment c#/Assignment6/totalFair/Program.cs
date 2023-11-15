using System;
using Assignment6;
using static System.Console;
namespace ConcessionApp

{
    class Program

    {
        const int TotalFare = 500;
        static void Main(string[] args)

        {

            Write("Enter the name: ");

            string name = ReadLine();

            Write("Enter the age: ");

            if (int.TryParse(ReadLine(), out int age))

            {
                string concessionDetails = ConcessionCalculator.CalculateConcession(age, name);

                WriteLine(concessionDetails);
            }

            else

            {
                WriteLine("Invalid input.");
            }

           ReadLine(); 

        }

    }
}

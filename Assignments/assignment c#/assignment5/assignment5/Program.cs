using System;
using static System.Console;

namespace assignment5
{
    class Program
    {
        static void Main()
        {
            WriteLine("enter first name");
            string firstName = ReadLine();

            WriteLine("enter laste name");
            string lastName = ReadLine();

            DisplayNames(firstName, lastName);
            ReadKey();

        }
        static void DisplayNames(string firstName, string lastName)
        {
            WriteLine($"First Name:{firstName.ToUpper()}");
            WriteLine($"last Name:{lastName.ToUpper()}");

        }
    }
}

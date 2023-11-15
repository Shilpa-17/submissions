using System;
using static System.Console;
    namespace assignment3
{
    class Program
    {
        static void Main()
        {
            // enter a word
            Write("enter a word: ");
            string word = ReadLine();

            // to show the length of the entered word
            int length = word.Length;
            WriteLine($"The length of the word '{word}' is: {length}");

        }

    }
}


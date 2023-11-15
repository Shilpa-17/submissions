using System;

class Program

{
    static void Main()

    {
        string input = "name";
        int position = 1; 

        if (position >= 0 && position < input.Length)

        {
            string result = input.Remove(position, 1);
            Console.WriteLine(result);

        }

        else

        {
            Console.WriteLine("Invalid position.");
        }

    }

}
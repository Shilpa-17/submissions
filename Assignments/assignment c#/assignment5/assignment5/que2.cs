using System;
using static System.Console;
class que2
{
    static void Main()
    {
        Write("enter string:");
        string inputString = ReadLine();

        Write("enter the letter to be counted:");
        char letterToCount = ReadLine()[0];

        int count = CountOccurences(inputString, letterToCount);
        WriteLine($"letter'{letterToCount}'appears {count} times in the string");

    }
    static int 
        CountOccurences(string inputString, char letterToCount)
    {
        int count = 0;
        foreach (char letter in inputString)
        {
            if (letter == letterToCount)
            {
                count++;
            }
        }
        return count;
    }

}
    


using System;
using System.IO;
using static System.Console;
class Program
{

    static void Main()

    {

        WriteLine("Enter the file path: ");

        string filePath = ReadLine();



        WriteLine("Enter the text to append: ");

        string textToAppend = ReadLine();

        try

        {           
            using (StreamWriter writer = new StreamWriter(filePath, true))

            {

                writer.WriteLine(textToAppend);

            }



           WriteLine("Text appended successfully!");

        }

        catch (Exception ex)

        {

            WriteLine("An error occurred: " + ex.Message);

        }

    }

}
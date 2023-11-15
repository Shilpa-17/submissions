using System;
using static System.Console;
delegate int CalculatorDelegate(int num1, int num2);
 

class Calculator

{
    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

 

    static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

 

    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    static void Main(string[] args)
    {

        CalculatorDelegate addDelegate = Add;
        CalculatorDelegate subtractDelegate = Subtract;
        CalculatorDelegate multiplyDelegate = Multiply;

 

        WriteLine("Enter two numbers:");
        int num1 = int.Parse(ReadLine());
        int num2 = int.Parse(ReadLine());

        WriteLine("~~~~~~~~~~~~~~~~~~~~~");


        WriteLine("Choose an operation:");

        WriteLine("1. Addition");

        WriteLine("2. Subtraction");

        WriteLine("3. Multiplication");

        int choice = int.Parse(ReadLine());

 

        int result = 0;

 

        switch (choice)

        {

            case 1:

                result = addDelegate(num1, num2);

                WriteLine("Result: " + result);

                break;

            case 2:

                result = subtractDelegate(num1, num2);

                WriteLine("Result: " + result);

                break;

            case 3:

                result = multiplyDelegate(num1, num2);

                WriteLine("Result: " + result);

                break;

            default:

                WriteLine("Invalid choice!");

                break;

        }

    }

}
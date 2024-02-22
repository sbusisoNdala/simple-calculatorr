using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Simple Calculator in C#");

        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is undefined.");
                }
                break;

            default:
                Console.WriteLine("Invalid operation entered.");
                break;
        }

        Console.ReadLine(); // Keep the console window open
    }
}
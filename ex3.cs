using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Modulus();
                    break;
                case 6:
                    Console.WriteLine("Exiting calculator...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Interactive Calculator!");
        Console.WriteLine("Please select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");
        Console.WriteLine("6. Exit");
    }

    static int GetUserChoice()
    {
        Console.Write("Enter your choice (1-6): ");
        return int.Parse(Console.ReadLine());
    }

    static void Addition()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 + num2;
        Console.WriteLine($"The result of {num1} + {num2} is {result}");
    }

    static void Subtraction()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 - num2;
        Console.WriteLine($"The result of {num1} - {num2} is {result}");
    }

    static void Multiplication()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 * num2;
        Console.WriteLine($"The result of {num1} * {num2} is {result}");
    }

    static void Division()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        double result = num1 / num2;
        Console.WriteLine($"The result of {num1} / {num2} is {result}");
    }

    static void Modulus()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        int result = num1 % num2;
        Console.WriteLine($"The result of {num1} % {num2} is {result}");
    }
}

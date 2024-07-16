using System;
class Lab1c
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
                    Add();
                    break;
                case 2:
                    Sub();
                    break;
                case 3:
                    Multi();
                    break;
                case 4:
                    Div();
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine();
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Please select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");
    }
    static int GetUserChoice()
    {
        Console.Write("Enter your choice (1-5): ");
        return int.Parse(Console.ReadLine());
    }
    static void Add()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 + num2;
        Console.WriteLine($"The result of {num1} + {num2} is {result}");
    }
    static void Sub()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 - num2;
        Console.WriteLine($"The result of {num1} - {num2} is {result}");
    }
    static void Multi()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 * num2;
        Console.WriteLine($"The result of {num1} * {num2} is {result}");
    }
    static void Div()
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
}

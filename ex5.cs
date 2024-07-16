using System;
class Lab1e
{
    static void Main(string[] args)
    {
        Console.Write("First number: ");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        Console.Write("Second number: ");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Invalid number");
            return;
        }
        CalSumDiff(num1, num2, out int sum, out int difference);
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
        Console.ReadLine();
    }
    static void CalSumDiff(int a, int b, out int sum, out int difference)
    {
        sum = a + b;
        difference = a - b;
    }
}

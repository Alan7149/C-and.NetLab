using System;
class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void GeneratePrimes(int start, int end)
    {
        Console.WriteLine("Prime numbers between {0} and {1}:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        GeneratePrimes(start, end);
        Console.ReadLine();
    }
}

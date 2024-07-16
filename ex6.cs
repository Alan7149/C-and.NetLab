using System;
class Lab1f
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Before swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        Swap(ref num1, ref num2);

        Console.WriteLine("After swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
        Console.ReadLine();
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.ReadLine();
    }
}

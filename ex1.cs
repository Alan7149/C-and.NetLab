using System;
class Lab1a
{
    static bool IsLeapYear(int year)
    {
        if (year % 4 == 0){
            if (year % 100 == 0){
                if (year % 400 == 0){
                    return true;
                }
                else{
                    return false;
                }
            }
            else{
                return true;
            }
        }
        else{
            return false;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        if (IsLeapYear(year)){
            Console.WriteLine($"{year} is a leap year.");
        }
        else{
            Console.WriteLine($"{year} is not a leap year.");
        }
        Console.ReadLine();
    }
}

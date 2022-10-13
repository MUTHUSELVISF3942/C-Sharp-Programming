using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int year;
        System.Console.WriteLine("Enter the year");
        year=int.Parse(Console.ReadLine());
        if(year%4==0)
        {
            System.Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            System.Console.WriteLine($"{year} is a not leap year");
        }
    }
}

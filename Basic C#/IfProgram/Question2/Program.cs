using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int age;
        System.Console.WriteLine("Enter the age:");
        age=int.Parse(Console.ReadLine());
        if(age>18)
        {
            System.Console.WriteLine("You are eligible for casting your vote.");

        }
        else
        {
            System.Console.WriteLine("You are not eligible for vote.");
        }
    }
}
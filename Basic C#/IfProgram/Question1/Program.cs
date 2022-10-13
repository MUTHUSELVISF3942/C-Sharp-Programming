using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        if(number%2==0)
        {
            System.Console.WriteLine($"{number} is an even number");
        }
        else
        {
            System.Console.WriteLine($"{number} is an odd number");
        }

    }
    
}

using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int cube;
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;i<=number;i++)
        {
            cube=i*i*i;
            System.Console.WriteLine($"Number is:{i} and cube of the {i} is:{cube}");
        }


    }
}

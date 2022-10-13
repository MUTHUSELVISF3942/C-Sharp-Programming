using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;i<=number;i++)
        {
            System.Console.WriteLine("{0}",2*i-1);
            sum+=2*i-1;
        }
        System.Console.WriteLine($"The sum of odd natural number upto {number} terms:{sum}");
    }
}

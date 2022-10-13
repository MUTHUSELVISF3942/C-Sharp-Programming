using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int multiplication;
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++)
        {
        multiplication=i*number;
        System.Console.WriteLine("{0}*{1}={2}",i,number,multiplication);
        }
    }
}

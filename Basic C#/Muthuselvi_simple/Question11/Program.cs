using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        int x=0,y=0;
        System.Console.WriteLine("Enter the number x:");
        x=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number y");
        y=int.Parse(Console.ReadLine());
        for(int i=0;i<=y;i++)
        {
            x+=x*y;
            System.Console.WriteLine(x);
        }
    }
}
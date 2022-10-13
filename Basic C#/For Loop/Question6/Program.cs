using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        char a='*';
        System.Console.WriteLine("Enter the number:");
        int row=int.Parse(Console.ReadLine());
        for(int i=1;i<=row;i++)
        {
            for(int j=1;j<=i;j++)
            System.Console.Write($"{a}");
        System.Console.Write("\n");
        }
    }
}

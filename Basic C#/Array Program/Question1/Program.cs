using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of an array:");
        int size=int.Parse(Console.ReadLine());
        string[] number=new string[size];
        System.Console.WriteLine("Enter the number:");
        for(size=0;size<number.Length;size++)
        {
            number[size]=Console.ReadLine();
        }
        foreach(string collection in number)
        {
            System.Console.WriteLine($"Element:{collection}");
        }
    }
}
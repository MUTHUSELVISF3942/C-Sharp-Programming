using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        double celsius=0,fahrenheit=0;
        System.Console.WriteLine("Enter the celsius:");
        celsius=double.Parse(Console.ReadLine());
        fahrenheit=(celsius*9/5)+32;
        System.Console.WriteLine("Fahrenheit:"+fahrenheit);
    }
}
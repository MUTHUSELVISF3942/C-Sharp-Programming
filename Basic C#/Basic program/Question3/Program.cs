using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        double celsius,fahrenheit,kelvin;
        Console.WriteLine("Enter the amount of celsius:");
        celsius=double.Parse(Console.ReadLine());
        fahrenheit=(celsius*9/5)+32;
        kelvin=celsius + 273;
        Console.WriteLine($"Kelvin:{kelvin}");
        Console.WriteLine($"Fahrenheit:{fahrenheit}");


    }
}

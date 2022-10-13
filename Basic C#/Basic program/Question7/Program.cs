using System;
namespace Question7;
class program
{
    public static void Main(string[] args)
    {
        double a,b,output;
        Console.WriteLine("Input the number a:");
        a=double.Parse(Console.ReadLine());
        Console.WriteLine("Input the number b:");
        b=double.Parse(Console.ReadLine());
        output=a*a+2*a*b+b*b;
        Console.WriteLine($"Output:{output}");
    }
}

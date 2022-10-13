using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        int sugar,output;
        System.Console.WriteLine("Enter the sugar level:");
        sugar=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Output:");
        if(sugar<90)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if(sugar>=90 && sugar<130)
        {
            System.Console.WriteLine("Normal");
        }
        else if(sugar>=130 && sugar<140)
        {
            System.Console.WriteLine("Medium");
        }
        else if(sugar>=140 && sugar<170)
        {
            System.Console.WriteLine("High sugar - try to reduce it from now");
        }
        else if(sugar>=170)
        {
            System.Console.WriteLine("You are a very high sugar patient");
        }
    }
}

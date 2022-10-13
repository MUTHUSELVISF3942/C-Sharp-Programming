using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int temperature;
        System.Console.WriteLine("Enter the temperature:");
        temperature=int.Parse(Console.ReadLine());
        if(temperature<0)
        {
            System.Console.WriteLine("Freezing weather");
        }
        else if(temperature>=0 && temperature<10)
        {
             System.Console.WriteLine("Very cold weather");
        }
        else if(temperature>=10 && temperature<20)
        {
         System.Console.WriteLine("Cold weather");
        }
        else if(temperature>=20 && temperature<30)
        {
         System.Console.WriteLine("Normal in temperature");
        }
        else if(temperature>=30 && temperature<40)
        {
             System.Console.WriteLine("Its hot");
        }
        else if(temperature>=40)
        {
            System.Console.WriteLine("Its very hot");
        }
        
    }
}
using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        int start,difference,sum=0,number,output=0;
        System.Console.WriteLine("Starting number:");
        start=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Difference:");
        difference=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"{start}");
        for(int i=5;i<number;i++)
        {
            i=start;
            output=i+2;
            System.Console.WriteLine($"{output}");
            
            
        }
        
    }
}

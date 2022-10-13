using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Number:");
        int i=1,sum=0;
        while(i<=number)
        {
            System.Console.WriteLine(i);
            sum+=i*i;
            i+=1;
        }
        
        System.Console.WriteLine($"Ouput:{sum}");
    }
}

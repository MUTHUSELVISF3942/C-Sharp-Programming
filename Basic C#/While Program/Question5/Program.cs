using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int sum=0,m=0;
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        while(number>0)
        {
            m=number%10;
            sum+=m;
            number=number/10;
        }
        
            System.Console.WriteLine($"Sum of digits of is {sum}");
    }
}

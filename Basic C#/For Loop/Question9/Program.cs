using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int number, sum=0,temp=0,remainder=0;
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        
        for(temp=number;number!=0;number=number/10)
        {
            remainder=number%10;
            sum=sum+(remainder*remainder*remainder);
        }
        if(sum==temp)
        {
            System.Console.WriteLine($"{temp} is an armstrong number");
        }
        else
        {
        System.Console.WriteLine($"{temp} is an not armstrong number");
        }
    }
}

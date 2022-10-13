using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int number,temp,r,sum=0;
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        temp=number;
        while(number>0)
        {
            r=number%10;
            sum=(sum*10)+r;
            number=number/10;
            
        }
        if(sum==temp)
        {
            System.Console.WriteLine($"{temp} is palindrome");
        }
        else
        {
            System.Console.WriteLine($"{temp} is not palindrome");
        }
    }
}
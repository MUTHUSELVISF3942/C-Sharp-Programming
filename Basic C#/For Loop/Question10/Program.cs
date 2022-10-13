using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        int number,flag=0,m;
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        m=number/2;
        for(int i=2;i<=m;i++)
        {
            if(number%i==0)
            {
                
                System.Console.WriteLine($"{number} is an not prime number");
                flag=1;
                break;
            }
            if(flag==0)
            {
                System.Console.WriteLine($"{number} is an prime number");
                break;
            }
        }
    }
}
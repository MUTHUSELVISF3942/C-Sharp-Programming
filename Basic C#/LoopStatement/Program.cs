using System;
namespace LoopStatement;
class Program
{
    public static void Main(string[] args)
    {
        for(int i=0;i<=25;i++)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
        }
        int sum=0;
        System.Console.WriteLine("Enter the initial value:");
        int initial=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the final value:");
        int final=int.Parse(Console.ReadLine());
        for(int j=initial;j<=final;j++)
        {
            
            sum+=j*j;
            
        }
        System.Console.WriteLine("Sum of square:"+sum);
    }
   
}
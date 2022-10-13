using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        int number,multiplay=0;
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        
        for(int i=1;i<=20;i++)
        {
            multiplay=i*number;
            System.Console.WriteLine("{0}*{1}={2}",i,number,multiplay);
            
        }
       
    }
}
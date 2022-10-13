using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int number,sum=0,term,i=1,m;
        System.Console.WriteLine("Enter the number of terms:");
        term=int.Parse(Console.ReadLine());
          System.Console.WriteLine("Enter the number:");
            number=int.Parse(Console.ReadLine());  
        do
        {
            
           
            m=number%10;
            sum+=m;
            number=number/10;
            System.Console.WriteLine($"The sum is {sum}");
            
           
        }while(number<0);
            
    }
}

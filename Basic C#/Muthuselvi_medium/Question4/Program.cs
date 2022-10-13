using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int remainder=0,temp=0,number;
       int sum=0;
      
       for(int i=1;i<=1000;i++)
       {
        temp=i;
           while(temp!=0)
        {
            remainder=temp%10;
            sum=(remainder*remainder*remainder);
            number=temp/10;
        }
        
            System.Console.WriteLine($"{temp}");
        
       
       
       }
        
    }
}

using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        int i=0,sum=0,sqaure=0;
        for(i=1;i<=100;i++)
        {
            if(i%2!=0)
            {
                System.Console.WriteLine(i);
                
            }
            
        }
        
        sqaure=(sum+i)*(sum+i);
        System.Console.WriteLine("Sum of square:"+sqaure);
    }
}
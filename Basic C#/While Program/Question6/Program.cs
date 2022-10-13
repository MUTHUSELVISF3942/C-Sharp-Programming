using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int value=1;
        while(value<=100)
        {
            if(value%2==0)

            {
                System.Console.WriteLine("Even number:"+value);
            }
            else
            {
                System.Console.WriteLine("Odd number:"+value);
            }
        }
        while(value<=100)
        {
            if(value/value==0)
            {
                System.Console.WriteLine("Prime number:"+value);
            }
        }
        
        
    }
}
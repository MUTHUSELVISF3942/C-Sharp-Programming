using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
         System.Console.WriteLine("Input:");
        string str=Console.ReadLine();
        int number=0;
        foreach(var value in str)
        {
            if(value>='0' && value<='9')
            {
                int i=value-'0';
                number+=i;
            
            }
        }
        System.Console.WriteLine(number);      
    }
}
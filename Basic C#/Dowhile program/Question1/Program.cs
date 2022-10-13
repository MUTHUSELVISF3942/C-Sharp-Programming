using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int number;
        string condition="";
        
        do
        {
            System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
         if(number%2==0)
            {
                System.Console.WriteLine("Given number is even number");
            }
            else
            {
                System.Console.WriteLine("Given number is odd number");
            }
            System.Console.WriteLine("Do you want to continue again:");
            condition=Console.ReadLine().ToLower();
        }while(condition=="yes");
    }
}

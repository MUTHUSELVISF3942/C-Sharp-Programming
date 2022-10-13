using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        
   
     System.Console.WriteLine("Enter the input in number format:");
        int number;
        bool temp=int.TryParse(Console.ReadLine(),out number);
        do
        {
            System.Console.WriteLine("Invalid input \nDo you want to continue again:");
            temp=int.TryParse(Console.ReadLine(),out number);
            
        }while(!temp);
        System.Console.WriteLine($"Valid input:{number}");
    }
}
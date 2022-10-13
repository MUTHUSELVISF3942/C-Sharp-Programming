using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i=1;
        while(i<=25)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
            i+=1;
        }

        System.Console.WriteLine("Enter the input in number format:");
        int number;
        bool temp=int.TryParse(Console.ReadLine(),out number);
        while(!temp)
        {
            System.Console.WriteLine("Invalid input \nEnter the number:");
            temp=int.TryParse(Console.ReadLine(),out number);
            
        }
        System.Console.WriteLine($"Valid input:{number}");
    }

}

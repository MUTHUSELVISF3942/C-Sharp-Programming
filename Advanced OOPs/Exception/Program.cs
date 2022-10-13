using System;
namespace Exception;
class Program
{
    public static void Main(string[] args)
    {
        try{
        System.Console.WriteLine("Enter the number1:");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number2:");
        int number2=int.Parse(Console.ReadLine());
        int output=number1/number2;
        System.Console.WriteLine("Division:"+output);
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("An exception occurred {0}",e.Message);
        }
        catch(FormatException e)
        {
            System.Console.WriteLine("An exception occurred {0}",e.Message);
        }         
    }
}
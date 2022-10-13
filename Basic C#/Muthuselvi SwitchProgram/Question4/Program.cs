using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        double a,b;
        int choice;
        System.Console.WriteLine("Enter the first number:");
        a=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        b=double.Parse(Console.ReadLine());
        System.Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Modulo Division\nEnter the choice:");
        choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("Result:"+(a+b));
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Result:"+(a-b));
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Result:"+(a*b));
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Result:"+(a/b));
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Result:"+(a%b));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
        
    }
}

using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        double a,b;
        char choice;
        System.Console.WriteLine("Enter the first number:");
        a=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        b=double.Parse(Console.ReadLine());
        System.Console.WriteLine("'+' Addition \n'-' Subtraction \n'*' Multiplication \n'/' Division \n'%' Modulo Division \nEnter the choice:");
        choice=char.Parse(Console.ReadLine());
        switch(choice)
        {
            case'+':
            {
                System.Console.WriteLine("Result:"+(a+b));
                break;
            }
            case'-':
            {
                System.Console.WriteLine("Result:"+(a-b));
                break;
            }
            case'*':
            {
                System.Console.WriteLine("Result:"+(a*b));
                break;
            }
            case'/':
            {
                System.Console.WriteLine("Result:"+(a/b));
                break;
            }
            case'%':
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

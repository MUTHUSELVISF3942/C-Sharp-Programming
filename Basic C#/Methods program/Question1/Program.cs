using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int number1,number2;
        System.Console.WriteLine("Enter the first number:");
        number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        number2=int.Parse(Console.ReadLine());
        int sum=Addition(number1,number2);
        System.Console.WriteLine("Addition:"+sum);
        Subtraction(number1,number2);
        int product=Multiplication();
        System.Console.WriteLine("Multiplication:"+product);
        Division();
        int Addition(int value1,int value2)
        {
            int sum;
            sum=value1+value2;
            return sum;
        }
        void Subtraction(int value1,int value2)
        {
            int difference;
            difference=value1-value2;
            System.Console.WriteLine("Subtraction:"+difference);
        }
        int Multiplication()
        {
            int product;
            product=number1*number2;
            return product;
        }
        void Division()
        {
            int quotient;
            quotient=number1/number2;
            System.Console.WriteLine("Division:"+quotient);
        }
    }
}

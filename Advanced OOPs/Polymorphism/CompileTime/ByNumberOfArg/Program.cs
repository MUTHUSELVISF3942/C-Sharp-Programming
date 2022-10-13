using System;
namespace ByNumberOfArg;
class Program
{
    //Methods with one parameter
    static void Display(int number)
    {
        System.Console.WriteLine("Argument:"+number);
    }
    //Methods with two parameter
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine("Argument:"+number1+"\nArgument:"+number2);
    }
    static void Main(string[] args)
    {
        Display(100);
        Display(100,200);
        Console.ReadLine();
    }
}
using System;
namespace ByType;
class Program
{
    //Method with integer parameter
    static void Display(int number)
    {
        System.Console.WriteLine("Integer type:"+number);
    }
    //Method with string parameter
    static void Display(string name)
    {
        System.Console.WriteLine("String type:"+name);
    }
    public static void Main(string[] args)
    {
        Display(100);
        Display("Selvi");
        Console.ReadLine();
    }
}
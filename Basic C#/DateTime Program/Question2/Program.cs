using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime();
        System.Console.WriteLine("Enter the date:");
        date=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Complete date:"+date);
        System.Console.WriteLine("Short Date:"+date.ToShortDateString());
        System.Console.WriteLine(date.ToLongDateString());
        System.Console.WriteLine(date);
        System.Console.WriteLine(date.ToShortDateString());
        System.Console.WriteLine(date.ToLongTimeString());
    }
}

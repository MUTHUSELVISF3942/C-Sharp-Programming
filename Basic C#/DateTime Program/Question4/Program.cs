using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
     DateTime date=new DateTime();
     System.Console.WriteLine("Input the date:");
     date=DateTime.Parse(Console.ReadLine());
     System.Console.WriteLine($"The day of the week for {date.ToShortDateString()} is:{date.DayOfWeek}");   
    }
}
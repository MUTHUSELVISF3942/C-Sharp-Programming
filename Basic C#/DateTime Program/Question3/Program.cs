using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2016,08,16,3,57,32,11);
       System.Console.WriteLine("Year:"+date.Year);
        System.Console.WriteLine("Month:"+date.Month);
        System.Console.WriteLine("Day:"+date.Day);
        System.Console.WriteLine("Hours:"+date.Hour);
        System.Console.WriteLine("Minutes:"+date.Minute);
        System.Console.WriteLine("Seconds:"+date.Second);
        System.Console.WriteLine("Milliseconds:"+date.Millisecond);
        
    }
}
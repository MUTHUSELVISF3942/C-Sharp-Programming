using System;
namespace DateMethod;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine("Year:"+date.Year);
        System.Console.WriteLine("Month:"+date.Month);
        System.Console.WriteLine("Day:"+date.Day);
        System.Console.WriteLine("Hours:"+date.Hour);
        System.Console.WriteLine("Minutes:"+date.Minute);
        System.Console.WriteLine("Seconds:"+date.Second);
       
        
        System.Console.WriteLine("Enter the DateTime:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        System.Console.WriteLine("Date:"+dob.ToString("yyyy/MM/dd"));
    }
}

using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Today;
        DateTime date1=date.AddDays(-1);
        DateTime date2=date.AddDays(1);
        System.Console.WriteLine("Yesterday:"+date1.ToShortDateString());
        System.Console.WriteLine("Tomorrow:"+date2.ToShortDateString());

    }
}
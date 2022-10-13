using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        System.Console.WriteLine("The date of today:"+date.ToShortDateString());
        System.Console.WriteLine("The twelve months are:");
        for(int i=0;i<12;i++)
        {
            System.Console.WriteLine(date.ToString("MMMM"));
            date=date.AddMonths(1);
        }
    }
}
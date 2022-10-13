using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2000,12,31);
        for(int i=0;i<=20;i++)
        {
        DateTime dates=date.AddYears(i);
        System.Console.WriteLine("{0:d}: Day {1} of {2}{3}",dates,dates.DayOfYear,dates.Year,DateTime.IsLeapYear(dates.Year)?"(Leap year)":"");


        }
    }
}
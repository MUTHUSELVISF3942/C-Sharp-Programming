using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dates=DateTime.Now;
        System.Console.WriteLine("Today="+DateTime.Now);
        TimeSpan duration=new TimeSpan (40,0,0,0);
        DateTime date=DateTime.Today.Add(duration);
        System.Console.WriteLine("{0:dddd}",date);

    }
}
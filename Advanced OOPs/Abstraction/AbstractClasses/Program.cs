using System;
namespace AbstractClasses;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion syncfusion=new Syncfusion();
        syncfusion.Name="Developer";
        syncfusion.Salary(30);

        TCS tcs=new TCS();
        tcs.Name="Testing";
        tcs.Salary(25);

        Console.ReadKey();
    }
}
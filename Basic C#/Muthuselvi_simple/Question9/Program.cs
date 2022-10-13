using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        string month="";
        int salary,leaves;
        System.Console.WriteLine("Enter the month:");
        month=Console.ReadLine();
        System.Console.WriteLine("Enter the number of leaves:");
        leaves=int.Parse(Console.ReadLine());

        string choice="";
       
        switch(choice)
        {
            case (choice=="January"):
            {
                salary=(31-leaves)*500;
                System.Console.WriteLine("Total Salary:"+salary);
                break;
            }
        }
    }
}
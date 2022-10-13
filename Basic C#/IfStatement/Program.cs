using System;
namespace IfStatement;
class Program
{
    public static void Main(string[] args)
    {
        int mark;
        System.Console.WriteLine("Enter the mark:");
        mark=int.Parse(Console.ReadLine());
        if(mark<=100 && mark>80)
        {
            System.Console.WriteLine("Grade A");
        }
        else if(mark<=80 && mark>60)
        {
            System.Console.WriteLine("Grade B");
        }
        else if(mark<=60 && mark>35)
        {
            System.Console.WriteLine("Grade C");
        }
        else if(mark<=35 && mark>0)
        {
            System.Console.WriteLine("Grade D");
        }
        else
        {
            System.Console.WriteLine("Invalid input");
        }
    }
}

using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("1-Monday\n2-Tuesday\n3-Wednesday\n4-Thursday\n5-Friday\n6-Saturday\n7-Sunday\nEnter the number:");
        int number=int.Parse(Console.ReadLine());
        switch(number)
        {
            case 1:
            {
                System.Console.WriteLine("Monday");
                break;
            }
             case 2:
            {
                System.Console.WriteLine("Tuesday");
                break;
            }
             case 3:
            {
                System.Console.WriteLine("Wednesday");
                break;
            }
             case 4:
            {
                System.Console.WriteLine("Thursday");
                break;
            }
             case 5:
            {
                System.Console.WriteLine("Friday");
                break;
            }
             case 6:
            {
                System.Console.WriteLine("Saturday");
                break;
            }
             case 7:
            {
                System.Console.WriteLine("Sunday");
                break;
            }
             default:
            {
                System.Console.WriteLine("Invalid input");
                break;
            }
        }
        
    }
}

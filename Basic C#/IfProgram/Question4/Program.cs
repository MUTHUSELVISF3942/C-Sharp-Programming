using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int first,second,third;
        System.Console.WriteLine("Enter the first number:");
        first=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        second=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the third number:");
        third=int.Parse(Console.ReadLine());
        if(first >= second && first >= third)
        {
            System.Console.WriteLine("The 1st number is the greatest among three");
        }
        else if(second >= first && second >= third)
        {
            System.Console.WriteLine("The 2nd number is the greatest among three");
        }
        else
        {
            System.Console.WriteLine("The 3rd number is the greatest among three");
        }
        
    }
}

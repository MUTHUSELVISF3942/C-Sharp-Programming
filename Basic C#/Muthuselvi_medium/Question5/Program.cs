using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int number,i;
        System.Console.WriteLine("Enter the year:");
        number=int.Parse(Console.ReadLine());
        for(i=1;i<=number;i++)
        {
            if(i)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
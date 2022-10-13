using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int physics, chemistry,maths;
        double percentage;
        System.Console.WriteLine("Enter the Physics:");
        physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Chemistry:");
        chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Maths:");
        maths=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine($"Physics:{physics}");
        System.Console.WriteLine($"Chemistry:{chemistry}");
        System.Console.WriteLine($"Maths:{maths}");
        percentage=(physics+chemistry+maths)/3;
        if(percentage>=75)
        {
            System.Console.WriteLine("The candidate is eligible for admission");
        }
        else
        {
            System.Console.WriteLine("The candidate is not eligible for admission");
        }
        
    }
}

using System;
namespace Question5;
class program
{
    public static void Main(string[] args)
    {
        int physics,chemistry,maths,sum;
        double percentage;
        Console.WriteLine("Enter the physics mark:");
        physics=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Chemistry mark:");
        chemistry=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the maths mark:");
        maths=int.Parse(Console.ReadLine());
        sum=physics+chemistry+maths;
        percentage=(sum*100)/300;
        Console.WriteLine($"Physics:{physics}");
        Console.WriteLine($"Chemistry:{chemistry}");
        Console.WriteLine($"Maths:{maths}");
        Console.WriteLine($"Sum:{sum}");
        Console.WriteLine($"Percentage:{percentage}");
    }
}
using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        double radius, height,volume;
        Console.WriteLine("Input the radius:");
        radius=double.Parse(Console.ReadLine());
        Console.WriteLine("Input the height:");
        height=double.Parse(Console.ReadLine());
        volume=3.14*radius*radius*height;
        Console.WriteLine($"Volume of cylinder:{volume}");
    }
}

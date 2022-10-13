using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        double radius=0.0,area=0,perimeter=0;
        System.Console.WriteLine("Enter the radius:");
        radius=double.Parse(Console.ReadLine());
        area=3.14*radius*radius;
        System.Console.WriteLine("Area of a circle:"+area);
        perimeter=2*3.14*radius;
        System.Console.WriteLine("Perimeter of a circle:"+perimeter);
    }
}
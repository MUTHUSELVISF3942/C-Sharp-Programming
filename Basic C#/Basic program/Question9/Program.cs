using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int speed,time;
        double distance;
        Console.WriteLine("Input the speed in km/hr:");
        speed=int.Parse(Console.ReadLine());
        Console.WriteLine("Input the time in second:");
        time=int.Parse(Console.ReadLine());
        distance=speed*time*5/18;
        Console.WriteLine($"Output:{distance} Meters");
        
        
    }
}

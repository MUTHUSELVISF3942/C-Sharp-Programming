using System;
namespace Question8;
class program
{
    public static void Main(string[] args)
    {
        double centimeter,meter,milimeter,inch,foot,mile;
        Console.WriteLine("Enter the meter value:");
        meter=Convert.ToDouble(Console.ReadLine());
        centimeter=meter*100;
        milimeter=centimeter*10;
        inch=39.3*meter;
        foot=12*meter;
        mile=0.0006213715277778*meter;
        Console.WriteLine($"Meter:{meter}");
        Console.WriteLine($"Centimeter:{centimeter}");
        Console.WriteLine($"Milimeter:{milimeter}");
        Console.WriteLine($"Inch:{inch}");
        Console.WriteLine($"Foot:{foot}");
        Console.WriteLine($"Mile:{mile}");

    }
}
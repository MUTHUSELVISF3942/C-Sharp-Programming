using System;
namespace Question6;
class program
{
    public static void Main(string[] args)
    {
        double price,total;
        Console.WriteLine("Enter the product price:");
        price=double.Parse(Console.ReadLine());
        total=price+price*0.18;
        Console.WriteLine($"Price:{price}");
        Console.WriteLine($"Total:{total}");

    }
}

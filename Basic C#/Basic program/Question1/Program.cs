using System;
namespace Question1;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the name:");
        string name=Console.ReadLine();
        //concatenation
        Console.WriteLine("Hello:"+name);
        //Placeholder
        Console.WriteLine("Hello:{0}",name);
        //Interpolation
        Console.WriteLine($"Hello:{name}");
    }
}
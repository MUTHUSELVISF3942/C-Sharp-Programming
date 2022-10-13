using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input radius of the circle:");
        int r=int.Parse(Console.ReadLine());

        System.Console.WriteLine("1. Area\n2. Perimeter\n3. Diameter\nInput the radius of circle:");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("The area is:"+(3.14*r*r));
                break;
            }
            case 2:
            {
                System.Console.WriteLine("The perimeter is:"+(2*3.14*r));
                break;
            }
            case 3:
            {
                System.Console.WriteLine("The diameter is:"+(2*r));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}

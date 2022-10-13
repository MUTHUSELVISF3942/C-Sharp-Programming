using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("India\nPakistan\nBangladesh\nEnter the input:");
        string choice=Console.ReadLine();
        switch(choice)
        {
            case "India":
            {
                System.Console.WriteLine("1. Gambir\n2. Ashwin\n3. Dhoni\n4. Jadeja");
                break;
            }
            case "Pakistan":
            {
                System.Console.WriteLine("1.Babar Azam\n2. Agha Salman\n3. Mohammad Amir\n4. Shaheen Afridi");
                break;
            }
            case "Bangladesh":
            {
                System.Console.WriteLine("1.Shakib AI Hasan\n2. Tamim Iqbal\n3. Mahmudullah\n4. Mushfiqur Rahim");
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

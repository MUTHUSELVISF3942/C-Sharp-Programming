using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        string password="HiTeam";
        System.Console.WriteLine("Enter the password:");
        password=Console.ReadLine();
        if(password=="HiTeam")
        {
            System.Console.WriteLine("Right password");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
    }
}

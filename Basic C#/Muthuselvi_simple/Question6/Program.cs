using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        string password="";
        System.Console.WriteLine("Input the password:");
        password=Console.ReadLine();
        if(password=="s3cr3t!P@sswOrd")
        {
            System.Console.WriteLine("Welcome");
        }
        else
        {
            System.Console.WriteLine("Wrong password!");
        }
    }
}
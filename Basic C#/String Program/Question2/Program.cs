using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string data="";
        System.Console.WriteLine("Input the string:");
        data=Console.ReadLine();
        int l=0;
        System.Console.WriteLine("The characters of the string are:");
        while(l<=data.Length-1)
        {
            System.Console.WriteLine(data[l]);
            
            l++;
        }
    }
}
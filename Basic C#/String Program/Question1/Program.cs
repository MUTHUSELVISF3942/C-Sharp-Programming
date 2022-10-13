using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string word="";
        
        System.Console.WriteLine("Input the string:");
        word=Console.ReadLine();
        int count=0;
        foreach(char c in word)
        {
            
            count++;
        }
        System.Console.WriteLine("Length of the string is:"+count);
    }
}

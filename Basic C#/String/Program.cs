using System;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        string longString="";
        string shortString="";
        int count=0;
        
        System.Console.WriteLine("Enter the long string:");
        longString=Console.ReadLine();
       
        System.Console.WriteLine("String to be searched:");
        shortString=Console.ReadLine();
        string[] split=longString.Split(new string[] {shortString},StringSplitOptions.None);
        foreach(string value in split)
        {
            
                count++;
            
        }    

        System.Console.WriteLine("String searched count is "+(count-1));
        
    }
}

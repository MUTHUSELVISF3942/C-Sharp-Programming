using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        string str="";
        System.Console.WriteLine("Input the string:");
        str=Console.ReadLine();
        int odd, even;
        string[] split=str.Split(new string[]{"12","4","32"},StringSplitOptions.None);
        foreach(string val in split)
        {
            System.Console.WriteLine(val);
        }
}    
}
using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        string str="";
        System.Console.WriteLine("Input the string:");
        str=Console.ReadLine();
        int i,j;
        char[] chr=new char[str.Length];
        for(i=0,j=str.Length-1;i<=j;i++,j--)
        {
           
                chr[i]=str[j];
                chr[j]=str[i];
           
        }
        System.Console.Write(chr);
    }
}
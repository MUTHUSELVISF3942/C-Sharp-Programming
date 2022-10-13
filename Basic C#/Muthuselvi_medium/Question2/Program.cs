using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int number,f1=0,f2=1,f3=0,i=2;
        System.Console.WriteLine("Input number of terms to display:");
        number=int.Parse(Console.ReadLine());
        System.Console.WriteLine(+f1+"\n"+f2);
        for(i=2;i<number;i++)
        {
            f3=f1+f2;
            System.Console.WriteLine(f3);
            f1=f2;
            f2=f3;
            
        }
         
    }
}
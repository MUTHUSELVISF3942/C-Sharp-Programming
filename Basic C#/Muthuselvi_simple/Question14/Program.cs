using System;
namespace Question14;
class Program
{
    public static void Main(string[] args)
    {
        int i,j,row;
        System.Console.WriteLine("Enter the row:");
        row=int.Parse(Console.ReadLine());
        for(i=0;i<=row;i++)
        {
            for(j=0;j<i;j++)
            {
                System.Console.Write(i);
                System.Console.Write("\n");
            }
            System.Console.Write("");
        }
    }
}
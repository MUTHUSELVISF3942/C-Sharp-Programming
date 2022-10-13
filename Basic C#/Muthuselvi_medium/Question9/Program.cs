using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
         int i,j,row,k;
        System.Console.WriteLine("Enter the number of rows:");
        row=int.Parse(Console.ReadLine());
        for(i=0;i<=row;i++)
        {
            for(j=0;j<=row-i;j++)
            {
                System.Console.Write("  ");
            }
            for(k=1;k<=2*i-1;k++)
            {
                System.Console.Write("*");
                System.Console.Write(" ");
            }
            System.Console.WriteLine(" ");
        }
    }
}

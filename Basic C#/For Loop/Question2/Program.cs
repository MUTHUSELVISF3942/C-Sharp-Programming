using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        double average;
        for(int i=1;i<=10;i++)
        sum+=i;
        average=sum/10;
        System.Console.WriteLine($"Sum:{sum}");
        System.Console.WriteLine($"Average:{average}");
    }
}

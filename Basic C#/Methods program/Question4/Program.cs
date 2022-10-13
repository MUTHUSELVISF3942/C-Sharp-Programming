using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number:");
        number=int.Parse(Console.ReadLine());
        Fibonacci();
        void Fibonacci()
        {
            int i=0,f1=0,f2=1,f3=0;
            for(i=0;i<=number;i++)
            {
                f3=f1+f2;
                System.Console.WriteLine(f3);
                f1=f2;
                f2=f3;
            }
        }
    }
}
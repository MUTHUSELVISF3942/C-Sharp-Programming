using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int number1,number2;
        System.Console.WriteLine("Enter the number:");
        number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the another number:");
        number2=int.Parse(Console.ReadLine());
        Swap(number1,number2);
        
        void Swap(int value1,int value2)
        {
            int temp;
            temp=value1;
            value1=value2;
            value2=temp;
            System.Console.WriteLine($"Now the 1st number is:{value1}, and the second number is:{value2}");
        }
    }
}

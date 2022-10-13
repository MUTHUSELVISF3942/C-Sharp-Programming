using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        char vowel;
        
        System.Console.WriteLine("Enter the vowel:");
        vowel=Convert.ToChar(Console.ReadLine());
        if(vowel=='a' || vowel=='e')
        {
            System.Console.WriteLine("It is a vowel");
        }
        else if(vowel=='i' || vowel=='o')
        {
            System.Console.WriteLine("It is a vowel");
        }
        else if(vowel=='u')
        {
            System.Console.WriteLine("It is a vowel");
        }
        else 
        {
            System.Console.WriteLine("It is not a vowel");
        }
    }
}
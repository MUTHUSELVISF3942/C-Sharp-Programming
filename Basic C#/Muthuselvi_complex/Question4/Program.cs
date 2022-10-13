using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            
            var uniqueCharArray = inputString.ToCharArray().ToArray();
            var resultString = new string(uniqueCharArray);
            Console.WriteLine(resultString);
            Console.ReadKey();
    }
}
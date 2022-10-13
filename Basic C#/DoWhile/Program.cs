using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        int number;
        string condition="";
        
        do
        {
            System.Console.WriteLine("Enter the number");
        number=int.Parse(Console.ReadLine());
         if(number%2==0)
            {
                System.Console.WriteLine("Even number");
            }
            else
            {
                System.Console.WriteLine("Odd number");
            }
            System.Console.WriteLine("Do you want to continue again:");
            condition=Console.ReadLine().ToLower();
          while(condition!="yes" && condition!="no")
          {
            System.Console.WriteLine("Wrong input");
            System.Console.WriteLine("Do you want to continue again:");
            condition=Console.ReadLine().ToLower();
          }
        }
        while(condition=="yes");

        
    }
}

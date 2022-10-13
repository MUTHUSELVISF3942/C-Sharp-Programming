using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
         System.Console.WriteLine("Enter the size of an array:");
        int size=int.Parse(Console.ReadLine());
        string[] number=new string[size];
        System.Console.WriteLine("Enter the number:");
        for(size=0;size<number.Length;size++)
        {
            number[size]=Console.ReadLine();
        }
        
        Console.Write("\nThe values store into the array are : \n");
   for(size=0;size<number.Length;size++)
     {
	   Console.Write($"{size}");
	 }
 
   Console.Write("\n\nThe values store into the array in reverse are :\n");
   for(size=number.Length-1;size>=0;size--)
      {
	   Console.Write($"{size}");
	  }
    }
}
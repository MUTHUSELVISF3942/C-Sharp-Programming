﻿using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
         string str1,str2;
  bool m;
	
       Console.Write("\n\nCheck whether a given substring is present in the given strig :\n");
       Console.Write("-------------------------------------------------------------------\n");	
        Console.Write("Input the string : ");
               str1 = Console.ReadLine();	

	    Console.Write("Input the substring to  search : ");
               str2 = Console.ReadLine();
               m=str1.Contains(str2); // boolean value tapped hare
    if (m) // check boolean value is true or false.
		Console.Write("The substring exists in the string.\n\n");
	else
		Console.Write("The substring is not exists in the string. \n\n");
    }
}
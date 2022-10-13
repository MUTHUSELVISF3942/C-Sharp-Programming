using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        string str="", reversestr = "";  
        Console.Write("Enter a string:");  
        str=Console.ReadLine();  
        for(int i=str.Length-1;i>=0;i--)  
        {  
            reversestr+=str[i].ToString();  
        }  
        if(reversestr==str)  
        {  
            Console.WriteLine("{0} is Palindrome",str,reversestr);  
        }  
        else  
        {  
            Console.WriteLine("{0} is not Palindrome",str,reversestr);  
        }  
        
         
    }
}
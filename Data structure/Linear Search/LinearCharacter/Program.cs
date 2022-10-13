using System;
namespace LinearCharacter;
class Program{
    public static void Main(string[] args)
    {
        char[] chars=new char[]{'a','u','r','s','p'};
        System.Console.WriteLine("Enter the character:");
        char char1=char.Parse(Console.ReadLine());
        int flag=0;
        for(int i=0;i<chars.Length;i++)
        {
            if(chars[i]==char1)
            {
                System.Console.WriteLine($"Character is found...\nCharacter:{char1} Index:{i}");
                flag=1;
            }
        }
        if(flag==0)
        {
            System.Console.WriteLine($"Character is not found...\nCharacter:{char1}");
        }
    }
}
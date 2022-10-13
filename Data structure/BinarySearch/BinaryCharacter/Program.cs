using System;
namespace BinaryCharacter;
class Program{
    public static void Main(string[] args)
    {
        char[] arr=new char[]{'a','b','e','t','s','d','j','m','f'};
        System.Console.WriteLine("Enter the character:");
        char char1=char.Parse(Console.ReadLine());
        Array.Sort(arr);
        int flag=0;
        int first=0,middle=0,last=arr.Length-1;;
        while(first<=last)
        {
            middle=(first+last)/2;
            if(char1==arr[middle])
            {
                System.Console.WriteLine($"Character is found....\nCharacter:{char1} Index:{middle}");
                flag=1;
            }
            if(char1<=arr[middle])
            {
                last=middle-1;
            }
            if(char1>=arr[middle])
            {
                first=middle+1;
            }
            
        }
        if(flag!=1)
        {
        System.Console.WriteLine("Character is not found");
        }
    }
}
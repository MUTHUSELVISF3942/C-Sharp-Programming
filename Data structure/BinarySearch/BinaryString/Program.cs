using System;
namespace BinaryInteger;
class Program{
    public static void Main(string[] args)
    {
        string[] arr=new string[]{"Selvi","Nivi","Murugan","Kumar","Arun","Francis"};
        System.Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        Array.Sort(arr);
        int flag=0;
        int first=0,middle=0,last=arr.Length-1;
        while(first<=last)
        {
            middle=(first+last)/2;
            if(str==arr[middle])
            {
                System.Console.WriteLine($"String is found....\nString:{str} Index:{middle}");
                flag=1;
            }
            if(string.Compare(str,arr[middle])<1)
            {
                last=middle-1;
            }
           else
            {
                first=middle+1;
            }
            
        }
        if(flag!=1)
        {
        System.Console.WriteLine("String is not found");
        }
    }
}
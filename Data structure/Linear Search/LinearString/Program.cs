using System;
namespace LinearString;
class Program{
    public static void Main(string[] args)
    {
        string[] str=new string[]{"Selvi","Nivi","Iyyappan","Murugan"};
        System.Console.WriteLine("Enter the string:");
        string str1=Console.ReadLine();
        int flag=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]==str1)
            {
                System.Console.WriteLine($"String is found...\nString:{str1} Index:{i}");
                flag=1;
            }   
        }
        if(flag==0)
        {
            System.Console.WriteLine($"String is not found...\nString:{str1}");
        }
            
                
        
         
    }
}
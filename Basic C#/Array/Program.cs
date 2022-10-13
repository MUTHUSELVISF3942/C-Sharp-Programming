using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size");
        int size=int.Parse(Console.ReadLine());
        
        string[] names=new string[size];
        System.Console.WriteLine("Enter the name");
        for(int i=0;i<names.Length;i++)
        {
            names[i]=Console.ReadLine();
           
        }
    System.Console.WriteLine("Name list:");
        for(int j= 0; j < names.Length; j++)
        {

        
        System.Console.WriteLine(names[j]);
        }
        
        System.Console.WriteLine("Search the name:");
        string search=Console.ReadLine();
        int count=0;
       
        for(int k=0;k<names.Length;k++)
        {
            if(search==names[k])
            {
                System.Console.WriteLine("The name is present in array");
                System.Console.WriteLine($"Name:{names[k]} ");
                System.Console.WriteLine($"Index value:{k}");
                count++;
            }
            
        }
        if(count == 0)
        {
            System.Console.WriteLine("The name is not present in array");
        }
     string search1=Console.ReadLine();
        int count1=0;
       
        foreach(string value in names)
        {
            if(search1==value)
            {
                System.Console.WriteLine("The name is present in array");
                
                count1++;
            }
            
        }
        if(count == 0)
        {
            System.Console.WriteLine("The name is not present in array");
        }
       
    }
}

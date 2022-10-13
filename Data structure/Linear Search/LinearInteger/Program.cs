using System;
namespace LinearInteger;
class Program{
    public static void Main(string[] args)
    {
        int[] arr=new int[]{101,200,543,12,76,34,54,87,23,64};
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        int flag=0;
        for(int i=0;i<=arr.Length;i++)
        {
            if(arr[i]==number)
            {
                System.Console.WriteLine($"Number is found...\nNumber:{number} Index:{i}");
                flag=1;
            }
            
        } 
        if(flag==0)
        {
            System.Console.WriteLine($"Number is not found...\nNumber:{number}");
        }    
    }
    
    

}
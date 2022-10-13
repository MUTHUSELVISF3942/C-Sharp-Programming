using System;
namespace BinaryInteger;
class Program{
    public static void Main(string[] args)
    {
        int[] arr=new int[]{10,80,30,40,110,60,70,50,90,100};
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
        Array.Sort(arr);
        int flag=0;
        int first=0,middle=0,last=arr.Length-1;;
        while(first<=last)
        {
            middle=(first+last)/2;
            if(number==arr[middle])
            {
                System.Console.WriteLine($"Number is found....\nNumber:{number} Index:{middle}");
                flag=1;
            }
            if(number<=arr[middle])
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
        System.Console.WriteLine("Number is not found");
        }
    }
}
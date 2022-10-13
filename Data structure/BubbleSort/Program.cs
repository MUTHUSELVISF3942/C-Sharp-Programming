using System;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr=new int[]{20,13,5,2,6,7,17};
        int i,j,temp=0;
        for(i=0;i<arr.Length-1;i++)
        {
            for(j=0;j<arr.Length-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
        System.Console.WriteLine("Sorting the data");
        foreach (var item in arr)
        {
            System.Console.WriteLine(+item);
        }
    }
}
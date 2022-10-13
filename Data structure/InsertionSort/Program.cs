using System;
namespace InsertionSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr=new int[]{20,10,3,5,16,2,7,17};
        int i,j,k,temp=0;
        for(i=1;i<arr.Length;i++)
        {
            k=arr[i];
            j=i-1;
            while(j>=0 && k<arr[j])
            {
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                j--;
               
            }

        }
        foreach (var item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
}
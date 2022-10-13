using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int first=0,second=1,third=0,number,i=1;
        System.Console.WriteLine("Enter the number of terms:");
        number=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Here is the fibonacci series upto to {number} terms:");
        System.Console.WriteLine(+first+"\n"+second+"");
        while(i<=number)
        {
            
            third=first+second;
            System.Console.WriteLine(third);
            first=second;
            second=third;
            i++;
            
            
        }
    }
}

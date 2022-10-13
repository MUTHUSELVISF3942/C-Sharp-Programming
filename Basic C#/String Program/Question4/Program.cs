using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        string message="";
        int count=1;
        int i=0;
        System.Console.WriteLine("Input the string:");
        message=Console.ReadLine();
        while(i<=message.Length-1)
        {
            if(message[i]==' ' || message[i]=='\n' || message[i]=='\t')
            {
            count++;
            }
            i++;
        }
            System.Console.WriteLine("Total number of words in the string is:"+count);
    }
}
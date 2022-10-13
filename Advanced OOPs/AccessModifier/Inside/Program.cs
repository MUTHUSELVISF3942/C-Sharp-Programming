using System;
using Outside;
namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        First one=new First();
        System.Console.WriteLine(one.publicNumber);
        System.Console.WriteLine(one.privateAccount);
        System.Console.WriteLine(one.internalNumber);
        Second two=new Second();
        System.Console.WriteLine(two.protectedOutput);
        System.Console.WriteLine(one.protectedInternalOutput);
    }
}
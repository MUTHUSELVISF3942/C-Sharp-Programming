using System;
namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.3,1.5,2.3);
        Box box2=new Box(10.3,13.1,12.4);
        Box box3;
        double volume=0.0;
        volume=box1.Calculate();
        System.Console.WriteLine("Volume of box1:"+volume);
        volume=box2.Calculate();
        System.Console.WriteLine("Volume of box2:"+volume);
        box3=box1+box2;
        volume=box3.Calculate();
        System.Console.WriteLine("Volume of box3:"+volume);

    }
}
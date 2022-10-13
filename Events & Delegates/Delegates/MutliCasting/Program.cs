using System;
namespace MultiCasting;
public delegate int Calculator(int n);
class Program{
     static int value=10; 
     public static int AddNum(int number)
     {
        value+=number;
        return value;
     }
     public static int MultiNum(int number)
     {
        value*=number;
        return value;
     }
     public static int GetNum()
     {
        return value;
     }
    public static void Main(string[] args)
    {
        Calculator c1;
        Calculator add=new Calculator(AddNum);
        Calculator mul=new Calculator(MultiNum);
        c1=add;
        c1+=mul;
        c1(5);
        
        System.Console.WriteLine("Value:{0}",GetNum());
        

    }
}
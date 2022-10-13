using System;
namespace SingleCasting;
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
        Calculator add=new Calculator(AddNum);
        Calculator mul=new Calculator(MultiNum);
        add(25);
        
        System.Console.WriteLine("Value{0}",GetNum());
        mul(5);
        System.Console.WriteLine("Value{0}",GetNum());
        

    }
}
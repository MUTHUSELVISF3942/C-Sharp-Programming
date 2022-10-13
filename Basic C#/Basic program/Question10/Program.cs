using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int value1=15, value2=20;
        System.Console.WriteLine($"a:{value1 > value2}");
        System.Console.WriteLine($"b:{value1 < value2}");
        System.Console.WriteLine($"c:{value1 >= value2}");
        System.Console.WriteLine($"d:{value1 == value2}");
        System.Console.WriteLine($"e:{value1 != value2}");
        System.Console.WriteLine($"f:{value1 <= value2}");
        System.Console.WriteLine($"g:{value1 >=10 && value2 >=10}");
        System.Console.WriteLine($"h:{value1>=10 || value2>=30}");
        System.Console.WriteLine($"i:{!(value1>20)}");
        string value=value1==15?"true":"false";
        System.Console.WriteLine($"j:{value}");
        System.Console.WriteLine($"k:{value1++}");
        System.Console.WriteLine($"l:{value1--}");
    }
}

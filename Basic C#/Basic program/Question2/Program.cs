using System;
namespace Question2;
class Program
{
public static void Main(string[] args)
{
    float firstNo,secondNo,add,sub,mul;
    float div,mod;
    Console.WriteLine("Input the first number:");
    firstNo=float.Parse(Console.ReadLine());
    Console.WriteLine("Input the second number:");
    secondNo=float.Parse(Console.ReadLine());
    add=firstNo+secondNo;
    sub=firstNo-secondNo;
    mul=firstNo*secondNo;
    div=firstNo/secondNo;
    mod=firstNo%secondNo;
    Console.WriteLine($"{firstNo}+{secondNo}={add}");
    Console.WriteLine($"{firstNo}-{secondNo}={sub}");
    Console.WriteLine($"{firstNo}*{secondNo}={mul}");
    Console.WriteLine($"{firstNo}/{secondNo}={div}");
    Console.WriteLine($"{firstNo}%{secondNo}={mod}");
}
}

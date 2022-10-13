using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
       
        int bpay,salary,da,hra,tax;
        System.Console.WriteLine("Enter the basic salary:");
        bpay=int.Parse(Console.ReadLine());
        da=(bpay*10)/100;
        hra=(bpay*10)/100;
        salary=bpay+da+hra;
        int annual=salary*12;
        tax=(annual*5)/100;
        int annualIncome=annual-tax;
        System.Console.WriteLine("Annual Income:"+annualIncome);
        
    

        
    }
}
using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int bpay=0,hra=0,da=0,salary=0,annual,annualIncome,tax,insurance;
        System.Console.WriteLine("Enter the basic salary:");
        bpay=int.Parse(Console.ReadLine());
        if(bpay<=10000)
        {
            hra=(bpay*20)/100;
            da=(bpay*80)/100;
            salary=bpay+hra+da;
            annual=salary*12;
            tax=(annual*6)/100;
            insurance=(annual*1)/100;
            annualIncome=annual-tax-insurance;
            System.Console.WriteLine("Annual Gross Salary:"+annualIncome);
        }
        else if(bpay<=20000)
        {
            hra=(bpay*25)/100;
            da=(bpay*90)/100;
            salary=bpay+hra+da;
            annual=salary*12;
            tax=(annual*6)/100;
            insurance=(annual*1)/100;
            annualIncome=annual-tax-insurance;
            System.Console.WriteLine("Annual Gross Salary:"+annualIncome);
        }
        else if(bpay>20000)
        {
            hra=(bpay*30)/100;
            da=(bpay*95)/100;
            salary=bpay+hra+da;
            annual=salary*12;
            tax=(annual*6)/100;
            insurance=(annual*1)/100;
            annualIncome=annual-tax-insurance;
            System.Console.WriteLine("Annual Gross Salary:"+annualIncome);
        }
    }
}
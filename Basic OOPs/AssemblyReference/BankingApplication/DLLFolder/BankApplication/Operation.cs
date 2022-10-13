using System;
using System.Collections.Generic;
using BankingLibrary;

namespace BankingOperation;
public class Operation
{
    public static void MainMenu()
    {
        List<BankDetail> bank=new List<BankDetail>();
        string str="";
        do{
            System.Console.WriteLine("Enter the name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the father name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter the gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the date of birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter the account type:");
            AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);
            BankDetail bankDetail=new BankDetail(name,fatherName,gender,dob,accountType);
            bank.Add(bankDetail);
            System.Console.WriteLine("Account number:"+bankDetail.AccountNumber);
            System.Console.WriteLine("Are you create another account:");
            str=Console.ReadLine().ToLower();

        }while(str=="yes");

        foreach(BankDetail bank1 in bank)
        {
            System.Console.WriteLine("Account Detail");
            System.Console.WriteLine("Account Number:"+bank1.AccountNumber);
            System.Console.WriteLine("Name:"+bank1.Name);
            System.Console.WriteLine("Father Name:"+bank1.FatherName);
            System.Console.WriteLine("Gender:"+bank1.Gender);
            System.Console.WriteLine("Date of Birth:"+bank1.DOB.ToShortDateString());
            System.Console.WriteLine("Account Type:"+bank1.AccountType);
            System.Console.WriteLine("Balance:"+bank1.Balance);
            bank1.Deposit();
            bank1.Withdraw();
            bank1.ShowBalance();
            
        }
    }
}
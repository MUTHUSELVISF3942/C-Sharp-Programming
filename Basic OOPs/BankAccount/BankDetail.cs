using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum AccountType{Default,SB,FD,RD}
    public enum Gender{Default,Male,Female,Transgender}
    public class BankDetail
    {
        private static int s_accountNumber=100;
        public int AccountNumber{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public Gender Gender{get;set;}
        public DateTime DOB{get;set;}
        public AccountType AccountType{get;set;}
        public int Balance{get;set;}

        public BankDetail(string name,string fatherName,Gender gender,DateTime dob,AccountType accountType)
        {
            s_accountNumber++;
            AccountNumber=s_accountNumber;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            AccountType=accountType;
            Balance=0;
        }
        public void showDetail()
        {
             System.Console.WriteLine("Account Detail");
            System.Console.WriteLine("Account Number:"+AccountNumber);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Date of Birth:"+DOB.ToShortDateString());
            System.Console.WriteLine("Account Type:"+AccountType);
            System.Console.WriteLine("Balance:"+Balance);
        }
        public void Deposit()
        {
            int depositAmount;
            System.Console.WriteLine("Enter the deposit amount:");
            depositAmount=int.Parse(Console.ReadLine());
            Balance+=depositAmount;
            System.Console.WriteLine("Balance:"+Balance);
            
        }
        public void Withdraw()
        {
            int withdrawAmount;
            System.Console.WriteLine("Enter the withdraw amount:");
            withdrawAmount=int.Parse(Console.ReadLine());
            
            if(Balance<=withdrawAmount)
            {
                System.Console.WriteLine("Sorry...Don't withdraw your balance is:"+Balance);
            }
            else
            {
                Balance-=withdrawAmount;
                
            }

        }
        public void ShowBalance()
        {
            
            System.Console.WriteLine("Balance:"+Balance);
            
        }
    }

}
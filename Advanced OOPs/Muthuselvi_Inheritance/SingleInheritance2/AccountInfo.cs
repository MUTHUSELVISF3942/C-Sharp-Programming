using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccountInfo:PersonalInfo
    {
        public static int s_accountNumber=1000;
        public int AccountNumber{get;set;}
        public string BranchName{get;set;}
        public string IFSCCode{get;set;}
        public int Balance{get;set;}
        public AccountInfo(string name,string fatherName,long mobileNumber,string mailId,DateTime dob,Gender gender,string branchName,string ifscCode):base(name,fatherName,mobileNumber,mailId,dob,gender)
        {
            s_accountNumber++;
            AccountNumber=s_accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            
        }
        public void BalanceAmount()
        {
            System.Console.WriteLine("Enter the amount:");
            Balance+=int.Parse(Console.ReadLine());
        }
        public void ShowAccount()
        {
            ShowDetail();
            System.Console.WriteLine("Account Number:"+AccountNumber);
            System.Console.WriteLine("Branch Name:"+BranchName);
            System.Console.WriteLine("IFSC Code:"+IFSCCode);
            BalanceAmount();
            System.Console.WriteLine("Balance:"+Balance);
            
            
            
        }
    }
}
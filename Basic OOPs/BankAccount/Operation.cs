using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public static class Operation
    {
        static BankDetail currentAccount=null;
        static List<BankDetail> bank=new List<BankDetail>();
        public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select option\n1. Registration\n2. Login\n3. Exit\nEnter the option:");
                int option=int.Parse(Console.ReadLine());
                 switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Mainmenu");
                    choice="no";
                    break;
                }

            }
            }while(choice=="yes");


        }
        public static void Registration()
        {
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
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter the account number:");
            int accountNumber=int.Parse(Console.ReadLine());
            foreach(BankDetail bank1 in bank)
            {
                if(bank1.AccountNumber==accountNumber)
                {
                    System.Console.WriteLine("Login successfully");
                    currentAccount=bank1;
                    SubMenu();
                }
            }
        }
         public static void SubMenu()
         {
            System.Console.WriteLine("Select option\n1. Show Details\n2. Deposit, Withdraw and Show balance\n3. Exit\nEnter the option:");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentAccount.showDetail();
                    break;
                }
                case 2:
                {
                    currentAccount.Deposit();
                    currentAccount.Withdraw();
                    currentAccount.ShowBalance();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Submenu");
                    break;
                }
            }
         }   
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ebill
{
    public class Operation
    {
        static EbillGeneration currentNumber=null;
        static List<EbillGeneration> ebill=new List<EbillGeneration>();
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
            System.Console.WriteLine("Enter the Username:");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter the phone number:");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mail id:");
            string mailId=Console.ReadLine();
           
            
            EbillGeneration ebillGeneration=new EbillGeneration(userName,phoneNumber,mailId);
            ebill.Add(ebillGeneration);
            System.Console.WriteLine("Meter Id:"+ebillGeneration.MeterId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter the account number:");
            string meterId=Console.ReadLine().ToUpper();
            foreach(EbillGeneration ebill1 in ebill)
            {
                if(ebill1.MeterId==meterId)
                {
                    System.Console.WriteLine("Login successfully");
                    currentNumber=ebill1;
                    SubMenu();
                }
            }
        }
         public static void SubMenu()
         {
            System.Console.WriteLine("Select option\n1. Show Details\n2. Calculate Bill\n3. Exit\nEnter the option:");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentNumber.ShowDetail();
                    break;
                }
                case 2:
                {
                    currentNumber.EbillDetail(); 
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
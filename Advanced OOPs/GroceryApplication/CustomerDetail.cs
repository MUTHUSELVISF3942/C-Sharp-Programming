using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApplication
{
    public class CustomerDetail:PersonalDetail,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId{get;}
        public double Balance{get;set;}
        public CustomerDetail(string name,string fatherName,Gender gender,long mobileNumber,DateTime dateOfBirth,string mailId):base(name,fatherName,gender,mobileNumber,dateOfBirth,mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            Balance=0;
        }
        public CustomerDetail(string data):base(data)
        {
            string[] value=data.Split(",");
            s_customerId=int.Parse(value[0]);
            CustomerId=value[0];
            Balance=double.Parse(value[1]);
            
        }

       
        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to be recharge:");
            Balance+=double.Parse(Console.ReadLine());
            
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("Customer Id:"+CustomerId);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father name:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Mobile number:"+MobileNumber);
            System.Console.WriteLine("Date of birth:"+DateOfBirth.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Mail Id:"+MailId);
            System.Console.WriteLine("Balance:"+Balance);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class CustomerDetail:PersonalDetails
    {
        public static int s_customerId=100;
        public string CustomerId{get;}
        public double WalletBalance{get;set;}
        public CustomerDetail(string aid,string name,String fatherName,Gender gender,long mobileNumber):base(aid,name,fatherName,gender,mobileNumber)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter the amount:");
            WalletBalance+=double.Parse(Console.ReadLine());
        }
        public void ShowCustomer()
        {
            System.Console.WriteLine("Customer ID:"+CustomerId);
            ShowDetails();
            Recharge();
            System.Console.WriteLine("Wallet Balance:"+WalletBalance);
        }
    }
}
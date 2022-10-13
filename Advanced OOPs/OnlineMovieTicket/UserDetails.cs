using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userId=1000;
        public double WalletBalance{get;set;}
        public string UserId{get;}
        public UserDetails(string name,int age,long phoneNumber):base(name,age,phoneNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            WalletBalance=0;

        }
        public void RechargeWallet()
        {
            System.Console.WriteLine("Enter the recharge amount:");
            double amount=double.Parse(Console.ReadLine());

            
            WalletBalance+=amount;
            System.Console.WriteLine("Wallet Balance:"+WalletBalance);

        }
        public UserDetails(string data):base(data)
        {
            string[] value=data.Split(",");
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            WalletBalance=int.Parse(value[4]);
        }
    }
}
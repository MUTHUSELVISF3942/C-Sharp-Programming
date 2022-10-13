using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class UserDetail
    {
        private static int s_userId=1000;
        public string UserId{get;}
        public string UserName{get;set;}
        public int Age{get;set;}
        public string City{get;set;}
        public long MobileNumber{get;set;}
        public int Balance{get;set;}
        public UserDetail(string userName,int age,string city,long mobileNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            UserName=userName;
            Age=age;
            City=city;
            MobileNumber=mobileNumber;
            Balance=0;
        }
        public UserDetail(string data)
        {
            string[] value=data.Split(",");
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            UserName=value[1];
            Age=int.Parse(value[2]);
            City=value[3];
            MobileNumber=long.Parse(value[4]);
            Balance=int.Parse(value[5]);
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("User Id:"+UserId);
            System.Console.WriteLine("User Name:"+UserName);
            System.Console.WriteLine("Age:"+Age);
            System.Console.WriteLine("City:"+City);
            System.Console.WriteLine("Mobile Number:"+MobileNumber);
            System.Console.WriteLine("Balance:"+Balance);
        }
   }
}
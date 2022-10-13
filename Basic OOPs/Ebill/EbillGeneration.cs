using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ebill
{
    public class EbillGeneration
    {
        private static int s_meterId=1000;
        public string MeterId{get;}
        public string UserName{get;set;}
        public long PhoneNumber{get;set;}
        public string MailId{get;set;}
        public int Unit{get;set;}
        
        public int Amount{get;set;}

        public EbillGeneration(string userName,long phoneNumber,string mailId)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=userName;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            Unit=0;
            Amount=0;
        }
        public void ShowDetail()
        {
            System.Console.WriteLine("Ebill Detail");
            System.Console.WriteLine("Meter Id:"+MeterId);
            System.Console.WriteLine("UserName:"+UserName);
            System.Console.WriteLine("Phone Number:"+PhoneNumber);
            System.Console.WriteLine("Mail Id:"+MailId);
            
        }
        public void EbillDetail()
        {
             System.Console.WriteLine("Enter the unit:");
            int unit=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Unit:"+Unit);
            int amount;
            if(Unit<100)
            {
                System.Console.WriteLine("Unit consumed is minimum 100..So free");
            }
            else if(Unit>=100 && Unit<200)
            {
                amount=Unit*3;
                System.Console.WriteLine("Amount:"+amount);
            }
            else if(Unit>=200 && Unit<400)
            {
                amount=Unit*5;
                System.Console.WriteLine("Amount:"+amount);
            }
            else if(Unit>=400)
            {
                amount=Unit*6;
                System.Console.WriteLine("Amount:"+amount);
            }
        }
    }
}
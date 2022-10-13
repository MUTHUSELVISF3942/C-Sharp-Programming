using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long MobileNumber{get;set;}
        public string MailId{get;set;}
        public DateTime DOB{get;set;}
        public Gender Gender{get;set;}
        public PersonalInfo(string name,string fatherName,long mobileNumber,string mailId,DateTime dob,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            MailId=mailId;
            DOB=dob;
            Gender=gender;
        }
        public void ShowDetail()
        {
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Mobile Number:"+MobileNumber);
            System.Console.WriteLine("Mail Id:"+MailId);
            System.Console.WriteLine("Date of Birth:"+DOB.ToShortDateString());
            System.Console.WriteLine("Gender:"+Gender);
        }
    }
}
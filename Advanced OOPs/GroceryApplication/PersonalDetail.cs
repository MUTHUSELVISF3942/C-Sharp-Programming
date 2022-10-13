using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetail
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public Gender Gender{ get; set; }
        public long MobileNumber { get; set; }
        public DateTime DateOfBirth{get;set;}
        public string MailId{get;set;}
        public PersonalDetail(string name,string fatherName,Gender gender,long mobileNumber,DateTime dateOfBirth,string mailId)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DateOfBirth=dateOfBirth;
            MailId=mailId;
        }
        public PersonalDetail(string data)
        {
            string[] value=data.Split(",");
            Name=value[2];
            FatherName=value[3];
            Gender=Enum.Parse<Gender>(value[4]);
            MobileNumber=long.Parse(value[5]);
            DateOfBirth=DateTime.ParseExact(value[6],"dd/MM/yyyy",null);
            MailId=value[7];
        }

        
        
        
        
    }
}
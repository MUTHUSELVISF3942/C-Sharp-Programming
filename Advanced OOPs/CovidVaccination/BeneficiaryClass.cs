using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum Gender{Default,Male,Female,Other}
    public class BeneficiaryClass
    {
        public static int s_registerNumber=1000;
        public string RegisterNumber{get;}
        public string Name{get;set;}
        public Gender Gender{get;set;}
        public long MobileNumber{get;set;}
        public string City{get;set;}
        public int Age{get;set;}

        public BeneficiaryClass(string name,Gender gender,long mobileNumber,string city,int age)
        {
            s_registerNumber++;
            RegisterNumber="BID"+s_registerNumber;
            Name=name;
            Gender=gender;
            MobileNumber=mobileNumber;
            City=city;
            Age=age;
        }
        public BeneficiaryClass(string data)
        {
            string[] value=data.Split(",");
            s_registerNumber=int.Parse(value[0].Remove(0,3));
            RegisterNumber=value[0];
            Name=value[1];
            Gender=Enum.Parse<Gender>(value[2]);
            MobileNumber=long.Parse(value[3]);
            City=value[4];
            Age=int.Parse(value[5]);
        }
       public void MyDetail()
        {
            System.Console.WriteLine("Register Number is:"+RegisterNumber);
            System.Console.WriteLine($"Register number:{RegisterNumber}\nName is:{Name}\nAge:{Age}\nGender:{Gender}\nMobile Number:{MobileNumber}\nCity:{City}"); 
            
        }

    }
}
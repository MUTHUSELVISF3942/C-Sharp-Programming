using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employment;

    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        public static int _aid=1000;
        public string AId{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public Gender Gender{get;set;}
        public long MobileNumber{get;set;}
        public PersonalDetails(string name,String fatherName,Gender gender,long mobileNumber)
        {
            _aid++;
            AId="AID"+_aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;

        }
        public void ShowDetails()
        {
            System.Console.WriteLine("AId:"+AId);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Mobile Number:"+MobileNumber);
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HieraricalInheritance;

    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetails
    {
        public static int s_aid=1000;
        public string AId{get;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public Gender Gender{get;set;}
        public long MobileNumber{get;set;}
        public PersonalDetails(string name,String fatherName,Gender gender,long mobileNumber)
        {
            s_aid++;
            AId="AID"+s_aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;

        }
         public PersonalDetails(string aid,string name,String fatherName,Gender gender,long mobileNumber)
        {
           
            AId=aid;
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

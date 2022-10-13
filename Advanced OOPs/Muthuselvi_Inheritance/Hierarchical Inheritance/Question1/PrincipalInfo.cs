using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalId=1000;
        public string PrincipalID{get;set;}
        public string Qualification{get;set;}
        public int YearOfExperience{get;set;}
        public DateTime DateOfJoining{get;set;}
        public PrincipalInfo(string name,string fatherName,long mobileNumber,string mailId,DateTime dob,Gender gender,string qualification,int year,DateTime date):base(name,fatherName,mobileNumber,mailId,dob,gender)
        {
            s_principalId++;
            PrincipalID="PID"+s_principalId;
            Qualification=qualification;
            YearOfExperience=year;
            DateOfJoining=date;
        }
        public void ShowPrincipal()
        {
            ShowDetail();
            System.Console.WriteLine("Principal ID:"+PrincipalID);
            System.Console.WriteLine("Qualification:"+Qualification);
            System.Console.WriteLine("Year of Experience:"+YearOfExperience);
            System.Console.WriteLine("Date of Joining:"+DateOfJoining);
        }
    }
}
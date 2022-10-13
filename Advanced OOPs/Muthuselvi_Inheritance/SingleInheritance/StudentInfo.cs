using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Branch{Default,EEE,ECE,CSE}
    public class StudentInfo:PersonalInfo
    {
        public static int s_registerNumber=1000;
        public string RegisterNumber{get;}
        
        public Branch Branch{get;set;}
        public int AcademicYear{get;set;}
        public StudentInfo(string name,string fatherName,long mobileNumber,string mailId,DateTime dob,Gender gender,Branch branch,int academicYear):base(name,fatherName,mobileNumber,mailId,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber="SID"+s_registerNumber;
            Branch=branch;
            AcademicYear=academicYear;

        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Register Number:"+RegisterNumber);
            ShowDetail();
            System.Console.WriteLine("Branch:"+Branch);
            System.Console.WriteLine("Academic Year:"+AcademicYear);
        }


    }
}
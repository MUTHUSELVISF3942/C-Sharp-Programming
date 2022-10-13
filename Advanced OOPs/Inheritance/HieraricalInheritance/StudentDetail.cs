using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HieraricalInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetail:PersonalDetails
    {
        public static int s_studentId=1000;
        public string StudentID{get;}
        public Department Department { get; set; }
        public string Year{get;set;}
        public StudentDetail(string aid,string name,String fatherName,Gender gender,long mobileNumber,Department department,string year):base(aid,name,fatherName,gender,mobileNumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;
        }
        public void ShowStudent()
        {
            System.Console.WriteLine("Student ID:"+StudentID);
            ShowDetails();
            System.Console.WriteLine("Department:"+Department);
            System.Console.WriteLine("Year:"+Year);
        }
        

    }
}
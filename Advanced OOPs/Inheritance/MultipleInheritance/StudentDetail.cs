using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Department{Default,EEE,ECE,CSE}
    public class StudentDetail:PersonalDetails,IMarkDetail
    {
        public static int s_studentId=1000;
        public string StudentID{get;}
        public Department Department { get; set; }
        public string Year{get;set;}
        public int Physics{get;set;}  
        public int Chemistry{get;set;}
        public int Maths{get;set;}
        public int Total{get;set;}
        public double Average{get;set;}
        public StudentDetail(string aid,string name,String fatherName,Gender gender,long mobileNumber,Department department,string year):base(aid,name,fatherName,gender,mobileNumber)
        {
            s_studentId++;
            StudentID="SID"+s_studentId;
            Department=department;
            Year=year;
        }
        public void GetMark(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3.0;
        }
        public void ShowMark()
        {
            System.Console.WriteLine("Physics:"+Physics);
            System.Console.WriteLine("Chemistry:"+Chemistry);
            System.Console.WriteLine("Maths:"+Maths);
            System.Console.WriteLine("Total:"+Total);
            System.Console.WriteLine("Average:"+Average);
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
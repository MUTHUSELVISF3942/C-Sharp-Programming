using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Department{Default,EEE,ECE,CSE}
    public class TeacherInfo:PersonalInfo
    {
        private int s_teacherId=1000;
        public string TeacherID{get;}
        public Department Department{get;set;}
        public string SubjectTeaching{get;set;}
        public string Qualification{get;set;}
        public int YearOfExperience{get;set;}
        public DateTime DateOfJoing{get;set;}
        public TeacherInfo(string name,string fatherName,long mobileNumber,string mailId,DateTime dob,Gender gender,Department department,string subject,string qualification,int year,DateTime date):base(name,fatherName,mobileNumber,mailId,dob,gender)
        {
            s_teacherId++;
            TeacherID="TID"+s_teacherId;
            Department=department;
            SubjectTeaching=subject;
            Qualification=qualification;
            YearOfExperience=year;
            DateOfJoing=date;
        }
        public void ShowTeacher()
        {
            ShowDetail();
            System.Console.WriteLine("Teacher ID:"+TeacherID);
            System.Console.WriteLine("Department:"+Department);
            System.Console.WriteLine("Subject Teaching:"+SubjectTeaching);
            System.Console.WriteLine("Year of Experience:"+YearOfExperience);
            System.Console.WriteLine("Date of Joining:"+DateOfJoing);
        }

    }
}
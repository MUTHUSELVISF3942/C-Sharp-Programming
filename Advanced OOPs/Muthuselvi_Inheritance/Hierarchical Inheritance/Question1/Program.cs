using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string name="Muthuselvi";
        string fatherName="Murugan";
        long mobileNumber=739827927;
        string mailId="selvi@gmail.com";
        DateTime dob=new DateTime(1999,04,19);
        Gender gender=Gender.Female;
        PersonalInfo personal=new PersonalInfo(name,fatherName,mobileNumber,mailId,dob,gender);
        personal.ShowDetail();
        StudentInfo student=new StudentInfo("Muthuselvi","Murugan",838278989,"selvi@gmail.com",new DateTime(1999,04,19),Gender.Female,Branch.ECE,2022);
        student.ShowStudent();
        TeacherInfo teacher=new TeacherInfo("Muthuselvi","Murugan",838278989,"selvi@gmail.com",new DateTime(1999,04,19),Gender.Female,Department.EEE,"Data structure","ME.,M.Phil.",);

    }
}
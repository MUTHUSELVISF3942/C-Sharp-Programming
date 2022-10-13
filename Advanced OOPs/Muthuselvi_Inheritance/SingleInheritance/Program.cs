using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        string name="Selvi";
        string fatherName="Murugan";
        long mobileNumber=7497984389;
        string mailId="selvi@gmail.com";
        DateTime dob=new DateTime(1999,04,19);
        Gender gender=Gender.Female;
        PersonalInfo personal=new PersonalInfo(name,fatherName,mobileNumber,mailId,dob,gender);
        personal.ShowDetail();
        StudentInfo student=new StudentInfo("Selvi","Murugan",9749732353,"selvi@gmail.com",new DateTime(1999,04,19),Gender.Female,Branch.EEE,2022);
        student.ShowStudent();

    }
}
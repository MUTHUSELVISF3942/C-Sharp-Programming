using System;
namespace SingleInheritance;
class Program{
    public static void Main(string[] args)
    {
        string name="Selvi";
        string fatherName="Murugan";
        Gender gender=Gender.Female;
        long mobileNumber=8468647823;
        PersonalDetails details=new PersonalDetails(name,fatherName,gender,mobileNumber);
        details.ShowDetails();
        StudentDetail student=new StudentDetail("AID99882","Selvi","Murugan",Gender.Female,973927398,Department.EEE,"Final");
        student.ShowStudent();

    }
}
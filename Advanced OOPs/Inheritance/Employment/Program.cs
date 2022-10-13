using System;
namespace Employment;
class Program{
    public static void Main(string[] args)
    {
        string name="Selvi";
        string fatherName="Murugan";
        Gender gender=Gender.Female;
        long mobileNumber=8468647823;
        PersonalDetails details=new PersonalDetails(name,fatherName,gender,mobileNumber);
        details.ShowDetails();

    }
}
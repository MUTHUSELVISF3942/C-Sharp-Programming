using System;
namespace MultipleInheritance;
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
        student.GetMark(90,99,97);
        student.Calculate();
        student.ShowMark();
        
        CustomerDetail customer=new CustomerDetail("AID99882","Selvi","Murugan",Gender.Female,973927398);
        customer.ShowCustomer();
        


    }
}
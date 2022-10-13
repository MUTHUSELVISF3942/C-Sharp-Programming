using System;
namespace PartialClass;
class Program
{
    public static void Main(string[] args)
    {
        StudentDetails student=new StudentDetails("Selvi","Murugan",new DateTime(2022,10,05),Gender.Female,90798479,"selvi@gmail.com",99,90,88);
        student.ShowDetails();   
    }
}
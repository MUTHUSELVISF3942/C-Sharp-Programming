using System;
namespace SingleInheritance2;
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
        AccountInfo account=new AccountInfo("Selvi","Murugan",9749732353,"selvi@gmail.com",new DateTime(1999,04,19),Gender.Female,"Udangudi","SBI220032");
        account.ShowAccount();

    }
}
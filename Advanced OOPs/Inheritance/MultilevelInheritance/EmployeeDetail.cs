using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class EmployeeDetail:StudentDetail
    {
        public static int s_employeeId=1000;
        public string EmployeeId{get;}
        public DateTime RegistrationDate{get;set;}
        public EmployeeDetail(string studentId,string aid,string name,String fatherName,Gender gender,long mobileNumber,Department department):base( studentId, aid, name, fatherName, gender, mobileNumber, department)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            RegistrationDate=DateTime.Now;
        }
        public void ShowEmployee()
        {
            System.Console.WriteLine("Employee ID:"+EmployeeId);
            ShowStudent();
            System.Console.WriteLine("Registration Date:"+RegistrationDate.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Renewal Date:"+RegistrationDate.AddDays(365).ToString("dd/MM/yyyy"));
        }

    }
}
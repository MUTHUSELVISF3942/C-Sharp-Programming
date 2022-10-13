using System;
using System.Collections.Generic;
using EmployeeLibrary;
namespace EmployeeOperation;
public class Operation
{
    public static void MainMenu()
    {
        List<EmployeeDetail> employee=new List<EmployeeDetail>();
        string str="";
        do{
            System.Console.WriteLine("Enter the employee name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the role:");
            string role=Console.ReadLine();
            System.Console.WriteLine("Enter the work location:");
            Location location=Enum.Parse<Location>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the team name:");
            string teamName=Console.ReadLine();
            System.Console.WriteLine("Enter the date of joining:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            
            
            EmployeeDetail employeeDetail=new EmployeeDetail(name,gender,role,location,teamName,dob);
            employee.Add(employeeDetail);
            System.Console.WriteLine("Employee Id:"+employeeDetail.EmployeeId);
            System.Console.WriteLine("Are you create another employee detail:");
            str=Console.ReadLine().ToLower();

        }while(str=="yes");

        foreach(EmployeeDetail employee1 in employee)
        {
            System.Console.WriteLine("Employee Detail");
            System.Console.WriteLine("Employee Id:"+employee1.EmployeeId);
            System.Console.WriteLine("Name:"+employee1.Name);
            System.Console.WriteLine("Role:"+employee1.Role);
            System.Console.WriteLine("Gender:"+employee1.Gender);
            System.Console.WriteLine("Work Location:"+employee1.Location);
            System.Console.WriteLine("Team Name:"+employee1.TeamName);
            System.Console.WriteLine("Date of Joining:"+employee1.DOB.ToShortDateString());
            employee1.EmployeeDays();
            
            
        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{
    public enum Location{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female,Transgender}
    public class EmployeeDetail
    {
         private static int s_employeeId=1000;
        public string EmployeeId{get;}
        public string Name{get;set;}
        
        public Gender Gender{get;set;}
        public string Role { get; set; }
        
        public Location Location { get; set; }
        public string TeamName { get; set; }
        public DateTime DOB{get;set;}
        public static int WorkingDays { get;set; }
        public static int Leave { get; set; }
        
        public EmployeeDetail(string name,Gender gender,string role,Location location,string teamName,DateTime dob)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            Name=name;
            
            Gender=gender;
            Role=role;
            Location=location;
            TeamName=teamName;
            DOB=dob;
            WorkingDays=0;
            Leave=0;
        }
        public void showDetail()
        {
             System.Console.WriteLine("Employee Detail");
            System.Console.WriteLine("Employee Id:"+EmployeeId);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Role:"+Role);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Work Location:"+Location);
            System.Console.WriteLine("Team Name:"+TeamName);
            System.Console.WriteLine("Date of Joining:"+DOB.ToShortDateString());
        }
        public void EmployeeDays()
        {
            int workingDays,leave;
            System.Console.WriteLine("Enter the working days:");
            workingDays=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the leave days:");
            leave=int.Parse(Console.ReadLine());
       
            int days=workingDays-leave;
            System.Console.WriteLine("Salary:"+days*500);
        }
        
        
        
        
        
        
    }
}
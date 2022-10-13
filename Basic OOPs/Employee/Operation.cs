using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{
    public static class Operation
    {
        static EmployeeDetail currentEmployee=null;
        static List<EmployeeDetail> employee=new List<EmployeeDetail>();
    public static void MainMenu()
    {
        string choice="yes";
        do
        {
            System.Console.WriteLine("Select option\n1. Registration\n2. Login\n3. Exit\nEnter the option:");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Mainmenu");
                    choice="no";
                    break;
                }

            }
            }while(choice=="yes");
    }
    public static void Registration()
    {
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
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter the employee id:");
            string employeeId=Console.ReadLine().ToUpper();
            foreach(EmployeeDetail employee1 in employee)
            {
                if(employee1.EmployeeId==employeeId)
                {
                    System.Console.WriteLine("Login successfully");
                    currentEmployee=employee1;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            System.Console.WriteLine("Select option\n1. Show Details\n2. Deposit, Withdraw, Show balance\n3. Exit\nEnter the option:");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentEmployee.showDetail();
                    break;
                }
                case 2:
                {
                    currentEmployee.EmployeeDays();   
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Submenu");
                    break;
                }
            }
    }
        
   
    
        
    }
}
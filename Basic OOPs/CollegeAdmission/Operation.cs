using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public static class Operation
    {
        static StudentDetails currentStudent=null;
        static List<StudentDetails> studentList=new List<StudentDetails>(); 
        public static void MainMenu()

        {
            string choice="yes";
            do{
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
             System.Console.WriteLine("Read data...");
            
            System.Console.WriteLine("Student Details");
            System.Console.WriteLine("Enter the student name:");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter the father's name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter the date of birth:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter the gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter the mobile number:");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mail Id:");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter the physics mark:");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the chemistry mark:");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the maths mark:");
            int maths=int.Parse(Console.ReadLine());
            StudentDetails student=new StudentDetails(name,fatherName,dob,gender,mobile,mail,physics,chemistry,maths);
            studentList.Add(student);
            System.Console.WriteLine("Admitted...");
            System.Console.WriteLine("Register Number:"+student.RegisterNumber );
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter the register number:");
            string registerNumber=Console.ReadLine().ToUpper();
            foreach(StudentDetails student in studentList)
            {
                if(student.RegisterNumber==registerNumber)
                {
                    System.Console.WriteLine("Login successfully");
                    currentStudent=student;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
            System.Console.WriteLine("Select option\n1. Show Details\n2. Check Eligibility\n3. Exit\nEnter the option:");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentStudent.showDetail();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Check Eligibility");
                    bool eligible=currentStudent.checkEligibility(75.0);
                    if(eligible)
                    {
                        System.Console.WriteLine("You are eligible for admission");
                    }
                    else
                    {
                        System.Console.WriteLine("You are not eligible for admission");
                    }
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
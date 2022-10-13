using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplication;


public class Operations
{
    public static void MainMenu()
    {
        //File
        List<StudentDetails> studentList=new List<StudentDetails>(); 
        string willing="";
        //Application form printout
        do
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
            System.Console.WriteLine("Are you willing to joining the college:");
            willing=Console.ReadLine().ToLower();

        }while(willing=="yes");
        

        foreach(StudentDetails student3 in studentList)
        {
        System.Console.WriteLine("Student Details are");
        System.Console.WriteLine("Register Number:"+student3.RegisterNumber);
        System.Console.WriteLine("Name:"+student3.Name);
        System.Console.WriteLine("Father's Name:"+student3.FatherName);
        System.Console.WriteLine("Date of Birth:"+student3.DOB.ToShortDateString());
        System.Console.WriteLine("Gender:"+student3.Gender);
        System.Console.WriteLine("Mobile Number:"+student3.Mobile);
        System.Console.WriteLine("Mail Id:"+student3.Mail);
        System.Console.WriteLine("Physics:"+student3.Physics);
        System.Console.WriteLine("Chemistry:"+student3.Chemistry);
        System.Console.WriteLine("Maths:"+student3.Maths);
        bool eligible=student3.checkEligibility(75.0);
        if(eligible)
        {
            System.Console.WriteLine("You are eligible for admission");
        }
        else
        {
            System.Console.WriteLine("You are not eligible for admission");
        }
        }
    }
}
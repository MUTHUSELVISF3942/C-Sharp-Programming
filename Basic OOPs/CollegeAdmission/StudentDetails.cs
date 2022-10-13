using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Used to process the college admission using the application
/// </summary>
namespace CollegeAdmission
{
    /// <summary>
    /// Used to select student's gender infomation
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// class <see cref="studentDeatil"/> used to collect student's details
    /// </summary>
    public class StudentDetails
    {
        private static int s_registerNumber=3000;
       ///
       /// 
       // private string _name; //Field declaration
      //  public string Name { get{return _name;} set{_name=value;}
      public string RegisterNumber{get;}
      /// <summary>
      /// Property 
      /// </summary>
      /// <value></value>
      public string Name { get; set; }//Auto property

      /// <summary>
      /// Property Father name used to provide father's name of the student
      /// </summary>
      public string FatherName { get; set; }
      /// <summary>
      /// Property Date of Birth used to provide the date of birth of the student
      /// </summary>
      /// <value></value>
      public DateTime DOB { get; set; }
      /// <summary>
      /// Property Gender used to provide the gender of the student
      /// </summary>
      /// <value></value>
      public Gender Gender { get; set; }
      /// <summary>
      /// Property mobile number used to provide mobile number of the student
      /// </summary>
      /// <value></value>
      public long Mobile { get; set; }
     /// <summary>
      /// Property mail used to provide mailid of the student
      /// </summary>
      public string Mail { get; set; }
     /// <summary>
      /// Property Physics used to provide physics mark of the student
      /// </summary>
      public int Physics { get; set; }
         /// <summary>
      /// Property Chemistry used to provide chemistry mark of the student
      /// </summary>
      public int Chemistry { get; set; }
      /// <summary>
      /// Property Maths used to provide maths mark of the student
      /// </summary>
   
      public int Maths { get; set; }  
    
      ///<summary>
      /// Constructor of <see cref="StudentDetail"/> class used to initialize values to its properties
      ///<summary>
      ///      
      //Parameterized constructor
    public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,long mobile,string mail,int physics,int chemistry,int maths)
    {
       
        s_registerNumber++;
        RegisterNumber="SF"+s_registerNumber;
        Name=name;
        FatherName=fatherName;
        DOB=dob;
        Gender=gender;
        Mail=mail;
        Physics=physics;
        Chemistry=chemistry;
        Maths=maths;
    }
    public void showDetail()
    {
         System.Console.WriteLine("Register Number:"+RegisterNumber);
        System.Console.WriteLine("Name:"+Name);
        System.Console.WriteLine("Father's Name:"+FatherName);
        System.Console.WriteLine("Date of Birth:"+DOB.ToShortDateString());
        System.Console.WriteLine("Gender:"+Gender);
        System.Console.WriteLine("Mobile Number:"+Mobile);
        System.Console.WriteLine("Mail Id:"+Mail);
        System.Console.WriteLine("Physics:"+Physics);
        System.Console.WriteLine("Chemistry:"+Chemistry);
        System.Console.WriteLine("Maths:"+Maths);
    }
    /// <summary>
    /// Method check eligibility get cutoff values as a parameter and check the eligibility of student .
    /// If curoff is less than or equal to is eligible and return true else false
    /// </summary>
    /// <param name="cutOff">Used to provide cutoff value for eligibility checking</param>
    /// <returns>Returns true if eligible else false</returns>
     public bool checkEligibility(double cutOff)
        {
            
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average>=cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   
    }
    
}
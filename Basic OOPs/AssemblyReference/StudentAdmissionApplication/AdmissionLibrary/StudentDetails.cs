using System;


namespace AdmissionLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_registerNumber=3000;
       // private string _name; //Field declaration
      //  public string Name { get{return _name;} set{_name=value;}
      public string RegisterNumber{get;}
      public string Name { get; set; }//Auto property
      public string FatherName { get; set; }
      public DateTime DOB { get; set; }
      public Gender Gender { get; set; }
      public long Mobile { get; set; }
      public string Mail { get; set; }
      public int Physics { get; set; }
      public int Chemistry { get; set; }
      public int Maths { get; set; }  
   
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
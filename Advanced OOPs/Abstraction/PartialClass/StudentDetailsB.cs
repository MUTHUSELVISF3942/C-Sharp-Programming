using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
        public bool CheckEligibility(double cutOff)
            {
                double average=(double)(Physics+Chemistry+Mathematics/3.0);
                if(average>=cutOff)
                return(true);
                else
                return(false);
                
            }
            public void ShowDetails()
            {
                
                
                System.Console.WriteLine($"Register number:{RegisterNumber}\nName is:{Name}\nFather's Name is:{FatherName}\nDOB:{DateofBirth.ToShortDateString()}\nGender:{Gender}\nPhoneNumber:{Phonenumber}\nMail ID:{MailId}\nPhysics Marks:{Physics}\nChemistry Marks:{Chemistry}\nMaths Marks:{Mathematics}"); 
            
            }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
   
         public enum Gender{Default,Male,Female,Transgender}
    public partial class StudentDetails
    {
         private static int s_registernumber=3000;
        
        public string RegisterNumber { get;  }
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Gender Gender { get; set; }
        public long Phonenumber { get; set; }
        public string MailId { get; set; }
        public int Physics { get; set; }
        public int  Mathematics { get; set; }
        public int  Chemistry { get; set; }
        

       
         
    }
}
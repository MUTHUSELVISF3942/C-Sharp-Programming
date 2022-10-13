using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum BloodGroup{Default,A_Positive,B_Positive,O_Positive,AB_Positive}
    public class UserRegistration
    {
        public static int s_donarId=1000;
        public int DonarId{get;}
        public string DonarName{get;set;}
        public long MobileNumber{get;set;}
        public BloodGroup BloodGroup{get;set;}
        public int Age{get;set;}
        public DateTime LastDonation{get;set;}
        public UserRegistration(st)
    }
}
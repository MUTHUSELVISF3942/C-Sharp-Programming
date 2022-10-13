using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionApplication
{
    public enum DepartmentName{Default,EEE,CSE,MECH,ECE}
   
   
    public class DepartmentDetails 
    {

        private static int s_departmentId=100;

        public string DepartmentId{get;}

        public DepartmentName Departments { get;set; }
        public int NumberOfSeats { get; set; }
    
        public DepartmentDetails(DepartmentName departmentName,int numberOfSeats)
        {
            s_departmentId++;
            DepartmentId="DID"+s_departmentId;
            Departments=departmentName;
            NumberOfSeats=numberOfSeats;
        }
    }
   
}
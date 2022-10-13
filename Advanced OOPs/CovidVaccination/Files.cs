using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CovidVaccination
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Covid"))
            {
                System.Console.WriteLine("Create a folder");
                Directory.CreateDirectory("Covid");
            }
            if(!File.Exists("Covid\\BeneficiaryDetails.csv"))
            {
                System.Console.WriteLine("Create beneficiary file");
                File.Create("Covid\\BeneficiaryDetail.csv");
            }
            /*if(!File.Exists("Covid\\VaccinationDetail.csv"))
            {
                System.Console.WriteLine("Create vaccination file");
                File.Create("Covid\\VaccinationDetail.csv");
            }
            if(!File.Exists("Covid\\VaccineDetail.csv"))
            {
                System.Console.WriteLine("Create vaccine file");
                File.Create("Covid\\VaccineDetail.csv");
            }*/
        }
        public static void ReadFile()
        {
            string[] beneficiary= File.ReadAllLines("Covid\\BeneficiaryDetail.csv");
            foreach(string data in beneficiary)
            {
                BeneficiaryClass beneficiary1=new BeneficiaryClass(data);
                Operation.beneficiaryList.Add(beneficiary1);
            }
            
            
        }
        public static void WriteToFile()
        {
            string[] BeneficiaryClass=new string[Operation.beneficiaryList.Count];
            for(int i=0;i<Operation.beneficiaryList.Count;i++)
            {
                BeneficiaryClass[i]=Operation.beneficiaryList[i].RegisterNumber+","+Operation.beneficiaryList[i].Name+","+Operation.beneficiaryList[i].Gender+","+Operation.beneficiaryList[i].MobileNumber+","+Operation.beneficiaryList[i].City+","+Operation.beneficiaryList[i].Age;
            }
            File.WriteAllLines("Covid\\BeneficiaryDetail.csv",BeneficiaryClass);
        }
       
    }
}
 /*
        public static void WriteToFile()
        {
            string[] StudentDetails=new string[Operations.StudentList.Count];
            for(int i=0;i<Operations.StudentList.Count;i++)
            {
                StudentDetails[i]=Operations.StudentList[i].RegisterNumber+","+Operations.StudentList[i].Name+","+Operations.StudentList[i].FatherName+","+Operations.StudentList[i].DateofBirth+","+Operations.StudentList[i].Gender+","+Operations.StudentList[i].Phonenumber+","+Operations.StudentList[i].MailId+","+Operations.StudentList[i].Physics+","+Operations.StudentList[i].Chemistry+","+Operations.StudentList[i].Mathematics;
            }
            File.WriteAllLines("College/StudentDetails.csv",StudentDetails);

        }*/
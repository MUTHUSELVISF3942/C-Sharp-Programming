using System;

using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CollegeAdmissionApplication
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Create folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Create student file");
                File.Create("College/StudentDetails.csv");

            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Create department file");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Create admission file");
                File.Create("College/AdmissionDetails.csv");
            }
            
        }
        public static void ReadFile()
        {
            string[] student=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in student)
            {
                StudentDetails student1=new StudentDetails(data);
                Operations.StudentList.Add(student1);

            }
        }
        public static void WriteToFile()
        {
            
            string[] StudentDetails=new string[Operations.StudentList._count];
            for(int i=0;i<Operations.StudentList._count;i++)
            {
                StudentDetails[i]=Operations.StudentList[i].RegisterNumber+","+Operations.StudentList[i].Name+","+Operations.StudentList[i].FatherName+","+Operations.StudentList[i].DateofBirth+","+Operations.StudentList[i].Gender+","+Operations.StudentList[i].Phonenumber+","+Operations.StudentList[i].MailId+","+Operations.StudentList[i].Physics+","+Operations.StudentList[i].Chemistry+","+Operations.StudentList[i].Mathematics;
            }
            File.WriteAllLines("College/StudentDetails.csv",StudentDetails);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ListFileManipulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<StudentDetail> student=new List<StudentDetail>();
            student.Add(new StudentDetail(){Name="Muthuselvi",FatherName="Murugan",Gender=Gender.Female,DOB=new DateTime(1999,04,19)});
            student.Add(new StudentDetail(){Name="Nivi",FatherName="Ravi",Gender=Gender.Female,DOB=new DateTime(1999,10,14)});
            student.Add(new StudentDetail(){Name="Iyyappan",FatherName="Arumugam",Gender=Gender.Male,DOB=new DateTime(1999,11,25)});
            Insert(student);
            Display();
        }
        static void Insert(List<StudentDetail> student)
        {
            StreamWriter sw=null;
            if(!File.Exists("Data.csv"))
            {
                System.Console.WriteLine("File does not exist.. Creating a new CSV file");
                File.Create("Data.csv");
            }
            else
            {
                System.Console.WriteLine("File found");
            }
            sw=new StreamWriter(File.OpenWrite("Data.csv"));
            foreach(var s in student)
            {
                sw.WriteLine(s.Name+","+s.FatherName+","+s.Gender+","+s.DOB.ToString("dd/MM/yyyy"));
            }
            sw.Close();
        }
        static void Display()
        {
            StreamReader sr=null;
            List<StudentDetail> dlist=new List<StudentDetail>();
            if(File.Exists("Data.csv"))
            {
                sr=new StreamReader(File.OpenRead("Data.csv"));
                while(!sr.EndOfStream)
                {
                    var line=sr.ReadLine();
                    var value=line.Split(",");
                    if(value[0]!="")
                    {
                        dlist.Add(new StudentDetail(){Name=value[0],FatherName=value[1],Gender=Enum.Parse<Gender>(value[2]),DOB=DateTime.ParseExact(value[3],"dd/MM/yyyy",null)});
                    }
                }
            }
            else
            {
                System.Console.WriteLine("File not found");
                 sr.Close();
            }
               
            foreach(var item in dlist)
            {
                System.Console.WriteLine(" Your name: \t"+item.Name+" \t Father Name:  \t" +item.FatherName+"\tGender:\t"+item.Gender+"\tDate of Birth:\t"+item.DOB.ToString("dd/MM/yyyy"));
            }
        }
    }
}
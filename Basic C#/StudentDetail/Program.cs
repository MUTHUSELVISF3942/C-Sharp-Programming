using System;
namespace StudentDetail;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("---------------");
        Console.WriteLine("Enter the student name:");
        string sName = Console.ReadLine();
        Console.WriteLine("Enter the father name:");
        string fName=Console.ReadLine();
        Console.WriteLine("Enter the email id:");
        string emailId=Console.ReadLine();
        Console.WriteLine("Enter the mobile number:");
        long mobileNo=long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the age:");
        int age=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the gender");
        string gender=Console.ReadLine();
        Console.WriteLine("Enter the chemistry mark:");
        int chemistry=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the physics mark:");
        int physics=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the maths mark:");
        int maths=int.Parse(Console.ReadLine());
        float average=(chemistry+physics+maths)/3;
        float percentage=(chemistry+physics+maths)/6;
        Console.WriteLine("Students Details");
        Console.WriteLine($"Student Name:{sName}");
        Console.WriteLine($"Father's Name:{fName}");
        Console.WriteLine($"Email ID:{emailId}");
        Console.WriteLine($"Mobile Number:{mobileNo}");
        Console.WriteLine($"Age:{age}");
        Console.WriteLine($"Gender:{gender}");
        Console.WriteLine($"Chemistry mark:{chemistry}");
        Console.WriteLine($"Physics mark:{physics}");
        Console.WriteLine($"Maths mark:{maths}");
        Console.WriteLine($"Average:{average}");
        Console.WriteLine($"Percentage:{percentage}");

    }
}
using System;
namespace Enumerated;
public enum Gender{Default,Male,Female,Transgender}
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select gender options Male,Female,Transgender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender);
        System.Console.WriteLine("Select gender options Male,Female,Transgender");
        Gender gender1=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender1);
        while(!temp || (int)gender1<4 && (int)gender1>0)
        {
            System.Console.WriteLine("Invalid gender \n Enter again:");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),out gender1);
        }
        System.Console.WriteLine(gender1);
        

    }
}
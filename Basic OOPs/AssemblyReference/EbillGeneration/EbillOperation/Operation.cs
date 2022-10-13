using System;
using System.Collections.Generic;
using EbillLibrary;
namespace EbillOperation;
public class Operation{
    public static void MainMenu()
    {
        List<EbillGeneration> ebill=new List<EbillGeneration>();
        string str="";
        do{
            System.Console.WriteLine("Enter the Username:");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter the phone number:");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mail id:");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Enter the unit:");
            int unit=int.Parse(Console.ReadLine());
            
            EbillGeneration ebillGeneration=new EbillGeneration(userName,phoneNumber,mailId,unit);
            ebill.Add(ebillGeneration);
            System.Console.WriteLine("Meter Id:"+ebillGeneration.MeterId);
            System.Console.WriteLine("Are you create another account:");
            str=Console.ReadLine().ToLower();

        }while(str=="yes");

        foreach(EbillGeneration ebill2 in ebill)
        {
            System.Console.WriteLine("Ebill Detail");
            System.Console.WriteLine("Meter Id:"+ebill2.MeterId);
            System.Console.WriteLine("UserName:"+ebill2.UserName);
            System.Console.WriteLine("Phone Number:"+ebill2.PhoneNumber);
            System.Console.WriteLine("Mail Id:"+ebill2.MailId);
            System.Console.WriteLine("Unit:"+ebill2.Unit);
            ebill2.EbillDetail();
        }
    }
}
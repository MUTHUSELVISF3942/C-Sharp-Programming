﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatDone="";
            int i;
            double hoursWorked, totalTime;
            List<TimeSheetEntry> entryList = new List<TimeSheetEntry>();
            Console.Write("Enter where you worked: ");
            whatDone = Console.ReadLine();
            Console.Write("How long did you work for it: ");
            hoursWorked = double.Parse(Console.ReadLine());
            TimeSheetEntry entry  = new TimeSheetEntry();
            entry.HoursWorked = hoursWorked;
            entry.WorkDone = whatDone;
            entryList.Add(entry);
            Console.Write("Do you want to enter more time:");
            string condition = Console.ReadLine().ToLower();
            while (condition == "yes")
            {
                TimeSheetEntry entry1=new TimeSheetEntry();
                Console.Write("Enter where you worked: ");
                whatDone = Console.ReadLine();
                Console.Write("How long did you work for it: ");
                hoursWorked = int.Parse(Console.ReadLine());
                entry1.HoursWorked = hoursWorked;
                entry1.WorkDone = whatDone;
                entryList.Add(entry1);
                Console.Write("Do you want to enter more time:");
                condition = Console.ReadLine();
            } 
            totalTime = 0;
            for (i = 0; i < entryList.Count; i++)
            {

                if (entryList[i].WorkDone.ToLower().Contains("acme"))
                {
                    totalTime += entryList[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalTime * 150 + " for the hours worked.");
            totalTime=0;
            for (int j = 0; j < entryList.Count; j++)
            {
                if (entryList[j].WorkDone.ToLower().Contains("abc"))
                {
                    totalTime += entryList[j].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalTime * 125 + " for the hours worked.");
            totalTime=0;
            for (i = 0; i < entryList.Count; i++)
            {
                totalTime += entryList[i].HoursWorked;
                
            }
            if (totalTime > 40)
            {
                Console.WriteLine("You will get paid $" + (((totalTime-40)*15)+(40*10)) + " for your work.");
                
            }
            else
            {
                Console.WriteLine("You will get paid $" + totalTime * 10 + " for your time.");
            }
            
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}

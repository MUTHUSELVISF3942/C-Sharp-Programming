using System;
namespace Question12;
class Program
{
    static void Main()
    {
	
  	int mn,yr;
  	
    Console.Write("\n\n Find  the number of days of a given month for a year :\n");
	Console.Write("-----------------------------------------------------------\n");	
    Console.Write(" Input the Month No. : ");
    mn = Convert.ToInt32(Console.ReadLine());	
    Console.Write(" Input the Year : ");
    yr = Convert.ToInt32(Console.ReadLine());		
    DateTimeFormatInfo dinfo = new DateTimeFormatInfo();
    string mnum =  dinfo.GetMonthName(mn);   
	int nodays = DateTime.DaysInMonth(yr,mn); 
	Console.WriteLine(" The Number of days in the month {0} is : {1} \n",mnum,nodays);

    }
}
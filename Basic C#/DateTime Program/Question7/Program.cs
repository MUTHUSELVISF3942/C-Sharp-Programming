using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date1=new DateTime(2016,8,1,0,0,0);
        DateTime date2=new DateTime(2016,8,1,12,0,0);
        int result=DateTime.Compare(date1,date2);
        string relation;
        if(result<0)
        {
            relation="is earlier than";
        }
        else if(result==0)
        {
            relation="is same as";
        }
        else
        {
            relation="is later than";
        }
         System.Console.WriteLine("{0} {1} {2}",date1,relation,date2);
    }
}
using System;
namespace Question8;
class Program
{
     private enum DateComparisonResult
   {
      Earlier = -1,
      Later = 1,
      TheSame = 0
   };

   public static void Main()
   {
      DateTime thisDate = DateTime.Today;


      DateTime thisDateNextYear, thisDateLastYear;

     
      thisDateNextYear = thisDate.AddYears(1);
      thisDateLastYear = thisDate.AddYears(-1);   

      DateComparisonResult comparison;
      
      comparison = (DateComparisonResult) thisDate.CompareTo(thisDateLastYear);
      Console.WriteLine("{0}: {1:d} is {2} than {3:d}", 
                        (int) comparison, thisDate, comparison.ToString().ToLower(), 
                        thisDateLastYear);

      
      comparison = (DateComparisonResult) thisDate.CompareTo(thisDateNextYear);
      Console.WriteLine("{0}: {1:d} is {2} than {3:d}", 
                        (int) comparison, thisDate, comparison.ToString().ToLower(), 
                        thisDateNextYear);
}
}

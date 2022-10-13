using System;
namespace CovidVaccination;
class Program
{
    public static void Main(string[] args)
    {
       //Files.Create();
        
        Files.ReadFile();
    
        Operation.MainMenu();
        Files.WriteToFile();
        
    }
}
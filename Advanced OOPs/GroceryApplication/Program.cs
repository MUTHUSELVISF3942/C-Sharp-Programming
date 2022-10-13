using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
             Operation.AddDefaultData();
             Files.Create();
             Files.ReadFile();
             Operation.MainMenu();
             Files.WriteFile();
        }
    }
}
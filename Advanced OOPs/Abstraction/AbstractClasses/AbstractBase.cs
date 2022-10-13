using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase
    {
        protected string name; //Normal field
        public abstract string Name{get;set;} //Abstract property
        public double Amount{get;set;} //Normal property
        public void display() //Normal method
        {
            System.Console.WriteLine(name);
        }
        public abstract void Salary(int dates); //Abstract method
    }
}
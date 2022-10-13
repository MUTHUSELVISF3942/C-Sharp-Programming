using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public double Area{get;set;}
        public double Length{get;set;}
        public double Breath{get;set;}
        public void CalculateArea()
        {
            double Length=10;
            double Breath=30;
            Area=Length*Breath;
            System.Console.WriteLine("Area:"+Area);
        }
        
    }
}
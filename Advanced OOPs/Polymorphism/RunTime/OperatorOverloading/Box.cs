using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Box
    {
        private double length;
        private double breath;
        private double height;
        
        public Box()
        {

        }
        public Box(double length1,double breath1,double height1)
        {
            length=length1;
            breath=breath1;
            height=height1;
            
        }
        public double Calculate()
        {
            return length*breath*height;
        }
        //Overload + operator to add two box objects
        public static Box operator +(Box box1,Box box2)
        {
                Box box=new Box();
                box.length=box1.length+box2.length;
                box.breath=box1.breath+box2.breath;
                box.height=box1.height+box2.height;
                return box;
        }
    }
}
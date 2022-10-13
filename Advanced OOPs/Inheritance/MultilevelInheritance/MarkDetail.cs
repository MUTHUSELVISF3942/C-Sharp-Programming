using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public interface IMarkDetail
    {
        int Physics{get;set;}  
        int Chemistry{get;set;}
        int Maths{get;set;}
        int Total{get;set;}
        double Average{get;set;}
        void GetMark(int physics,int chemistry,int maths);
        void Calculate();
        void ShowMark();
    }
}
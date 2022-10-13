using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class Dog:Animal
    {
        //Sealed method
        public override void MakeSound()
        {
            System.Console.WriteLine("Dog sound");
        }
    }
}
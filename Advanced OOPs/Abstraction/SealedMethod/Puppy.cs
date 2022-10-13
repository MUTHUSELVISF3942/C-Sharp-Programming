using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Puppy:Dog
    {
        //trying to override selaed mathod
        public override void MakeSound()
        {
            System.Console.WriteLine("Puppy sound");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
    public class PersonalDetails
    {
       
        public string Name{get;set;}
        public int Age{get;set;}
        public long PhoneNumber{get;set;}
        public PersonalDetails(string name,int age,long phoneNumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phoneNumber;

        }
        public PersonalDetails(string data)
        {
            string[] value=data.Split(",");
            Name=value[1];
            Age=int.Parse(value[2]);
            PhoneNumber=long.Parse(value[3]);
        }

    }
}
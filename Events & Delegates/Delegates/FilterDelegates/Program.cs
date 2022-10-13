using System;
using System.Collections.Generic;
namespace FilterDelegates;
class program
{
    public static void Main(string[] args)
    {
        Person person1=new Person(){Name="Selvi",Age=23};
        Person person2=new Person(){Name="Nivi",Age=23};
        Person person3=new Person(){Name="Murugan",Age=49};
        Person person4=new Person(){Name="Iyyappan",Age=23};
        Person person5=new Person(){Name="Arun",Age=10};
        Person person6=new Person(){Name="Kumar",Age=22};
        List<Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};
        DisplayPeople("Children",people,IsChild);
        DisplayPeople("Voters",people,IsVoter);
        DisplayPeople("Adult",people,IsAdult);
        DisplayPeople("Senior",people,IsSenior);
       
    }
    static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
    {
        System.Console.WriteLine("People in "+title+" list are:");
        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine("{0},is {1} years old",p.Name,p.Age);
            }
        }
    }
    static bool IsChild(Person p){return p.Age<15;}
    static bool IsVoter(Person p){return p.Age>=18;}
    static bool IsAdult(Person p)
    {
        if(p.Age>=18 && p.Age<50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool IsSenior(Person p)
    {
        return p.Age>=50;
    }
}

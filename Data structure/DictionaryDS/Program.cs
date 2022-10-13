using System;
namespace DictionaryDs;
class program
{
    public static void Main(string[] args)
    {
        Dictionary<int,string>a=new Dictionary<int, string>();
        a.Add(123,"asdfd");
        
        a.Add(23,"asdfd");

        a.Add(3,"asdfd");

        a.Add(13,"asdfd");

        a.Add(22,"asdfd");

        a.Add(2,"asdfd");

        a.Containskey(3);

        a.ContainsValue("asdfd");

        a.ElementAt(2);

        a.Remove(22);
        a.Remove(123);
    }
    }
        
    

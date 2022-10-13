using System.Collections;
namespace ListDs
{
    
        
    class program
    {
        ArrayList asgfd=new ArrayList();

        public static void Main(string[] args)
        {
        // var asgfd=new ArrayList(){1,"ghjgj",1.0};

        List<int> data=new List<int>();

        data.AddElement(10);
        data.AddElement(20);
        data.AddElement(50);
        data.AddElement(90);
        data.AddElement(80);
        data.Insert(3,56);
        //data.RemoveAt(5);
        data.Remove(10);
        for (int i = 0; i<=data.Count; i++)
        {
            System.Console.WriteLine(data[i]);
        }
        // foreach (var datas in data)
        // {
        //         System.Console.WriteLine(datas);
        // }    
    }
    }

}
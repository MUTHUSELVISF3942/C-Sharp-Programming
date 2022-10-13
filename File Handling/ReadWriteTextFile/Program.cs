using System;
using System.IO;
namespace ReadWriteTextFile;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else
        {
            System.Console.WriteLine("Folder exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File created");
        }
        else
        {
            System.Console.WriteLine("File found");
        }
        System.Console.WriteLine("Select option\n1.Read file info\n2.Write file info");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try
                {
                    sr=new StreamReader("TestFolder/Test.txt"); //Pass the file path and file name to the streamreader constructor
                    line=sr.ReadLine(); //Read the first line of text
                    while(line!=null)
                    {
                        System.Console.WriteLine(line); //write the line to console window
                        line=sr.ReadLine(); //Read the next line of text
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Execute finally block..");
                        sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try
                {
                string[] old=File.ReadAllLines("TestFolder/Test.txt"); //Pass the file path and file name to the streamwriter constructor to open
                sw=new StreamWriter("TestFolder/Test.txt");
                System.Console.WriteLine("Enter the new content to be placed in file");
                string info=Console.ReadLine();
                string old1=" ";
                foreach(string text in old)
                {
                    old1=old1+"\n"+text; //Append old text info
                }
                old1=old1+"\n"+info; //Append our input text
                sw.WriteLine(old1); //write to file
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }
                finally
                {
                    if(sw!=null)
                    {
                        sw.Close();
                    }
                }
                break;
            }
        }
    }
}
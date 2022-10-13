using System;
using System.IO;
namespace FilesAndFolders;
class Program
{
    public static void Main(string[] args)
    {
        string Path=@"C:\Users\MuthuselviMurugan\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=Path+"/Selvi";
        string filePath=Path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found...So, creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Directory found");
        }
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found... Creating file");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }
        
        System.Console.WriteLine("Select option\n1.Create Folder\n2.Create File\n3.Delete Folder\n4.Delete File");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            //Create folder get one data
            case 1:
            {
                System.Console.WriteLine("Enter folder name you want to create");
                string name=Console.ReadLine();
                string newPath=Path+"\\"+name;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                    System.Console.WriteLine("Folder name created...");
                }
                break;
            }
            //Create file get two data
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create:");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file extension you want to create:");
                string fileExtension=Console.ReadLine();
                string newPath=Path+"\\"+fileName+"."+fileExtension;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                    System.Console.WriteLine("File name created...");
                }
                else
                {
                    System.Console.WriteLine("File name already exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(Path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string folder=Console.ReadLine();
                string newPath=Path+"\\"+folder;
                foreach(string name in Directory.GetDirectories(Path))
                {
                    
                    if(name==newPath)
                    {
                        try
                        {
                        Directory.Delete(newPath);
                        System.Console.WriteLine("Folder deleted");
                        }
                        catch(DirectoryNotFoundException e)
                        {
                            System.Console.WriteLine("Directory not found");
                        }
                    }
                    
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(Path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select file you want to delete:");
                string file=Console.ReadLine();
                System.Console.WriteLine("Select file extension you want to delete:");
                string extension=Console.ReadLine();
                string newPath=Path+"\\"+file+"."+extension;
                foreach(string name in Directory.GetFiles(Path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        System.Console.WriteLine("File deleted");
                    }
                }
                break;
            }

        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MedicalStore
{
    public class Files
    {
         public static void Create()
        {
            if(!Directory.Exists("MedicalStore"))
            {
                System.Console.WriteLine("Create folder");
                Directory.CreateDirectory("MedicalStore");
            }
            if(!File.Exists("MedicalStore/UserDetails.csv"))
            {
                System.Console.WriteLine("Create user file");
                File.Create("MedicalStore/UserDetails.csv");

            }
            if(!File.Exists("MedicalStore/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Create medicine file");
                File.Create("MedicalStore/MedicineDetails.csv");
            }
            if(!File.Exists("MedicalStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Create Order file");
                File.Create("MedicalStore/OrderDetails.csv");
            }
            
        }
        public static void ReadFile()
        {
            string[] user=File.ReadAllLines("MedicalStore/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetail user1=new UserDetail(data);
                Operation.userList.AddElement(user1);

            }
            string[] medicine=File.ReadAllLines("MedicalStore/MedicineDetails.csv");
            foreach(string data in medicine)
            {
                MedicineDetail medicine1=new MedicineDetail(data);
                Operation.medicineList.AddElement(medicine1);

            }
            string[] order=File.ReadAllLines("MedicalStore/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails order1=new OrderDetails(data);
                Operation.orderList.AddElement(order1);

            }
        }
        public static void WriteToFile()
        {
            
            string[] UserDetails=new string[Operation.userList.count];
            for(int i=0;i<Operation.userList.count;i++)
            {
                UserDetails[i]=Operation.userList[i].UserId+","+Operation.userList[i].UserName+","+Operation.userList[i].Age+","+Operation.userList[i].City+","+Operation.userList[i].MobileNumber+","+Operation.userList[i].Balance;
            }
            File.WriteAllLines("MedicalStore/UserDetails.csv",UserDetails);


            string[] MedicineDetails=new string[Operation.medicineList.count];
            for(int i=0;i<Operation.medicineList.count;i++)
            {
                MedicineDetails[i]=Operation.medicineList[i].MedicineId+","+Operation.medicineList[i].MedicineName+","+Operation.medicineList[i].AvailableCount+","+Operation.medicineList[i].Price;
            }
            File.WriteAllLines("MedicalStore/MedicineDetails.csv",MedicineDetails);


             string[] OrderDetails=new string[Operation.orderList.count];
            for(int i=0;i<Operation.orderList.count;i++)
            {
                OrderDetails[i]=Operation.orderList[i].OrderId+","+Operation.orderList[i].UserId+","+Operation.orderList[i].MedicineId+","+Operation.orderList[i].MedicineCount+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].OrderDate+","+Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalStore/OrderDetails.csv",OrderDetails);

        }
    }
}
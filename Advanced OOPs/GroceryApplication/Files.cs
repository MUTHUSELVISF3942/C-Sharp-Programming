using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace GroceryApplication
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("GroceryApplication"))
            {
                Directory.CreateDirectory("GroceryApplication");
            }
            if(!File.Exists("GroceryApplication/CustomerDetails.csv"))
            {
                File.Create("GroceryApplication/CustomerDetails.csv");
            }
            if(!File.Exists("GroceryApplication/ProductDetails.csv"))
            {
                File.Create("GroceryApplication/ProductDetails.csv");
            }
            if(!File.Exists("GroceryApplication/BookingDetails.csv"))
            {
                File.Create("GroceryApplication/BookingDetails.csv");
            }
            if(!File.Exists("GroceryApplication/OrderDetails.csv"))
            {
                File.Create("GroceryApplication/OrderDetails.csv");
            }
        }
        public static void ReadFile()
        {
            string[] customer=File.ReadAllLines("GroceryApplication/CustomerDetails.csv");
            foreach(string data in customer)
            {
                CustomerDetail customer1=new CustomerDetail(data);
                Operation.CustomerList.Add(customer1);
            }

            string[] product=File.ReadAllLines("GroceryApplication/ProductDetails.csv");
            foreach(string data in product)
            {
                ProductDetail product1=new ProductDetail(data);
                Operation.ProductList.Add(product1);
            }

            string[] booking=File.ReadAllLines("GroceryApplication/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetail booking1=new BookingDetail(data);
                Operation.BookingList.Add(booking1);
            }

            string[] order=File.ReadAllLines("GroceryApplication/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetail order1=new OrderDetail(data);
                Operation.OrderList.Add(order1);
            }
        }
        public static void WriteFile()
        {
            string[] CustomerDetail=new string[Operation.CustomerList.Count];
            for(int i=0;i<Operation.CustomerList.Count;i++)
            {
                CustomerDetail[i]=Operation.CustomerList[i].CustomerId+","+Operation.CustomerList[i].Name+","+Operation.CustomerList[i].FatherName+","+Operation.CustomerList[i].Gender+","+Operation.CustomerList[i].MobileNumber+","+Operation.CustomerList[i].DateOfBirth+","+Operation.CustomerList[i].MailId+","+Operation.CustomerList[i].Balance;
            }
            File.WriteAllLines(("GroceryApplication/CustomerDetails.csv"),CustomerDetail);

            string[] ProductDetail=new string[Operation.CustomerList.Count];
            for(int i=0;i<Operation.CustomerList.Count;i++)
            {
                CustomerDetail[i]=Operation.CustomerList[i].CustomerId+","+Operation.CustomerList[i].Name+","+Operation.CustomerList[i].FatherName+","+Operation.CustomerList[i].Gender+","+Operation.CustomerList[i].MobileNumber+","+Operation.CustomerList[i].DateOfBirth+","+Operation.CustomerList[i].MailId+","+Operation.CustomerList[i].Balance;
            }
            File.WriteAllLines(("GroceryApplication/CustomerDetails.csv"),CustomerDetail);

            string[] CustomerDetail=new string[Operation.CustomerList.Count];
            for(int i=0;i<Operation.CustomerList.Count;i++)
            {
                CustomerDetail[i]=Operation.CustomerList[i].CustomerId+","+Operation.CustomerList[i].Name+","+Operation.CustomerList[i].FatherName+","+Operation.CustomerList[i].Gender+","+Operation.CustomerList[i].MobileNumber+","+Operation.CustomerList[i].DateOfBirth+","+Operation.CustomerList[i].MailId+","+Operation.CustomerList[i].Balance;
            }
            File.WriteAllLines(("GroceryApplication/CustomerDetails.csv"),CustomerDetail);

            string[] CustomerDetail=new string[Operation.CustomerList.Count];
            for(int i=0;i<Operation.CustomerList.Count;i++)
            {
                CustomerDetail[i]=Operation.CustomerList[i].CustomerId+","+Operation.CustomerList[i].Name+","+Operation.CustomerList[i].FatherName+","+Operation.CustomerList[i].Gender+","+Operation.CustomerList[i].MobileNumber+","+Operation.CustomerList[i].DateOfBirth+","+Operation.CustomerList[i].MailId+","+Operation.CustomerList[i].Balance;
            }
            File.WriteAllLines(("GroceryApplication/CustomerDetails.csv"),CustomerDetail);
        }
    }
}
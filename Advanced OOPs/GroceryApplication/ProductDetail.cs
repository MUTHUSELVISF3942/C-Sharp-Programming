using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApplication
{
    public class ProductDetail
    {
        private static int s_productId=100;
        public string ProductId{get;}
        public string ProductName{get;set;}
        public int Quantity{get;set;}
        public double Price{get;set;}
        public ProductDetail(string productName,int quantity,double price)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            Quantity=quantity;
            Price=price;
        }
        public ProductDetail(string data)
        {
            string[] value=data.Split(",");
            s_productId=int.Parse(value[0].Remove(0,3));
            ProductId=value[0];
            ProductName=value[1];
            Quantity=int.Parse(value[2]);
            Price=double.Parse(value[3]);
        }
       
        public void ShowProduct()
        {
            System.Console.WriteLine("Product Id:"+ProductId+ "Product Name:"+ProductName+ "Quantity:"+Quantity+ "Price:"+Price);
           
        }

    }
}
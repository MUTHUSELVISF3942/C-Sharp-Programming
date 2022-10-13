using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApplication
{
    public class OrderDetail
    {
        private static int s_orderId=100;
        public string OrderId{get;}
        public string BookId{get;}
        public string ProductId{get;}
        public int OrderQuantity{get;set;}
        public double OrderPrice{get;set;}
        public OrderDetail(string bookId,string productId,int orderQuantity,double orderPrice)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookId=bookId;
            ProductId=productId;
            OrderQuantity=orderQuantity;
            OrderPrice=orderPrice;
        }
         public OrderDetail(string data)
        {
            string[] value=data.Split(",");
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            BookId=value[1];
            ProductId=value[2];
            OrderQuantity=int.Parse(value[3]);
            OrderPrice=double.Parse(value[4]);
        }
       
        public void ShowOrderDetail()
        {
            System.Console.WriteLine("Order Id:"+OrderId);
            System.Console.WriteLine("Booking Id:"+BookId);
            System.Console.WriteLine("Product Id:"+OrderId);
            System.Console.WriteLine("Order Quantity:"+OrderQuantity);
            System.Console.WriteLine("Order Price:"+OrderPrice);
        }
    }
}
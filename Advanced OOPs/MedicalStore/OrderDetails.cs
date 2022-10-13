using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=2000;

        public string OrderId{get;}
        public string UserId{get;}
        public string MedicineId{get;}
        public int MedicineCount{get;set;}
        public int TotalPrice{get;set;}
        public DateTime OrderDate{get;set;}
        
        public OrderStatus OrderStatus{get;set;}

         public OrderDetails(string userId, string medicineId, int medicineCount, int totalPrice, DateTime orderDate, OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId = "OID"+s_orderId;
            UserId = userId;
            MedicineId = medicineId;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
          public OrderDetails(string data)
        {
            string[] value=data.Split(",");
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            UserId=value[1];
            MedicineId=value[2];
            MedicineCount=int.Parse(value[3]);
            TotalPrice=int.Parse(value[4]);
            OrderDate=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(value[6]);
        }

    }
}
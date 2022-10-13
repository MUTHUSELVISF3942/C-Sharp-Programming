using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryApplication
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetail
    {
        private static int s_bookId=3000;
        public string BookId{get;}
        public string CustomerId{get;}
        public double TotalPrice{get;set;}
        public DateTime DateOfBooking{get;set;}
        public BookingStatus BookingStatus { get; set; }
        public BookingDetail(string customerId,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }
       
         public BookingDetail(string data)
        {
            string[] value=data.Split(",");
            s_bookId=int.Parse(value[0].Remove(0,3));
            BookId=value[0];
            CustomerId=value[1];
            TotalPrice=double.Parse(value[2]);
            DateOfBooking=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(value[4],true);
        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("Booking Id:"+BookId);
            System.Console.WriteLine("Customer Id:"+CustomerId);
            System.Console.WriteLine("Total price:"+TotalPrice);
            System.Console.WriteLine("Date of booking:"+DateOfBooking.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Booking status:"+BookingStatus);
        }
        
        
    }
}
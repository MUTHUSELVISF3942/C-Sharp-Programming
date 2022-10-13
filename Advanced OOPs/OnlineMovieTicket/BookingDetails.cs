using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
    public enum BookingStatus{Default,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=7000;
        public string BookingId{get;}
        public string UserId { get;}
        public string MovieId { get;}
        public string TheatreId{get;}
        public int SeatCount{get;set;}
        public int TotalAmount{get;set;}
        public BookingStatus BookingStatus{get;set;}
        
        /// <summary>
        /// create constructor in booking details
        /// </summary>
       
        public BookingDetails(string userId,string movieId,string theatreId,int seatCount,int totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }
        public BookingDetails(string data)
        {
            string[] value=data.Split(",");
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            UserId= value[1];
            MovieId=value[2];
            TheatreId=value[3];
            SeatCount=int.Parse(value[4]);
            TotalAmount=int.Parse(value[5]);
            BookingStatus=Enum.Parse<BookingStatus>(value[6],true);
        }
        
        
    }
}
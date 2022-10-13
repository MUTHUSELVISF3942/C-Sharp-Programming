using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
    public class ScreeningDetails
    {
        public string MovieId { get;}
        public string TheatreId{get;}
        public int NoOfSeatsAvailable{get;set;}
        public int TicketPrice{get;set;}
        public ScreeningDetails(string movieId,string theatreId,int ticketPrice,int noOfSeatsAvailable)
        {
            MovieId=movieId;
            TheatreId=theatreId;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetails(string data)
        {
            string[] value=data.Split(",");
            MovieId=value[0];
            MovieId=value[1];
            NoOfSeatsAvailable=int.Parse(value[3]);
            TicketPrice=int.Parse(value[2]);
        }

    }
}
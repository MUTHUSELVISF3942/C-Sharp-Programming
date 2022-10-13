using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace OnlineMovieTicket
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicket"))
            {
                Directory.CreateDirectory("MovieTicket");
            }
            if(!File.Exists("MovieTicket/UserDetails.csv"))
            {
                File.Create("MovieTicket/UserDetails.csv");
            }
            if(!File.Exists("MovieTicket/BookingDetails.csv"))
            {
                File.Create("MovieTicket/BookingDetails.csv");
            }
            if(!File.Exists("MovieTicket/MovieDetails.csv"))
            {
                File.Create("MovieTicket/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicket/ScreeningDetails.csv"))
            {
                File.Create("MovieTicket/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieTicket/TheatreDetails.csv"))
            {
                File.Create("MovieTicket/TheatreDetails.csv");
            }

        }
        public static void ReadFile()
        {
            string[] user=File.ReadAllLines("MovieTicket/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetails user1=new UserDetails(data);
                Operation.UserList.Add(user1);
            }


            string[] booking=File.ReadAllLines("MovieTicket/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails booking1=new BookingDetails(data);
                Operation.BookingList.Add(booking1);
            }


            string[] movie=File.ReadAllLines("MovieTicket/MovieDetails.csv");
            foreach(string data in movie)
            {
                MovieDetails movie1=new MovieDetails(data);
                Operation.MovieList.Add(movie1);
            }


            string[] screen=File.ReadAllLines("MovieTicket/ScreeningDetails.csv");
            foreach(string data in screen)
            {
                ScreeningDetails screen1=new ScreeningDetails(data);
                Operation.ScreeningList.Add(screen1);
            }


            string[] theatre=File.ReadAllLines("MovieTicket/TheatreDetails.csv");
            foreach(string data in theatre)
            {
                TheatreDetails theatre1=new TheatreDetails(data);
                Operation.TheatreList.Add(theatre1);
            }
        }
        public static void WriteFile()
        {
            string[] UserDetail=new string[Operation.UserList.Count];
            for(int i=0;i<Operation.UserList.Count;i++)
            {
                UserDetail[i]=Operation.UserList[i].UserId+","+Operation.UserList[i].Name+","+Operation.UserList[i].Age+","+Operation.UserList[i].PhoneNumber+","+Operation.UserList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicket/UserDetails.csv",UserDetail);

            string[] BookingDetail=new string[Operation.BookingList.Count];
            for(int i=0;i<Operation.BookingList.Count;i++)
            {
                BookingDetail[i]=Operation.BookingList[i].BookingId+","+Operation.BookingList[i].UserId+","+Operation.BookingList[i].MovieId+","+Operation.BookingList[i].TheatreId+","+Operation.BookingList[i].SeatCount+","+Operation.BookingList[i].TotalAmount+","+Operation.BookingList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTicket/BookingDetails.csv",BookingDetail);

            string[] ScreenDetail=new string[Operation.ScreeningList.Count];
            for(int i=0;i<Operation.ScreeningList.Count;i++)
            {
                ScreenDetail[i]=Operation.ScreeningList[i].MovieId+","+Operation.ScreeningList[i].TheatreId+","+Operation.ScreeningList[i].TicketPrice+","+Operation.ScreeningList[i].NoOfSeatsAvailable;
            }
            File.WriteAllLines("MovieTicket/ScreeningDetails.csv",ScreenDetail);

            string[] MovieDetail=new string[Operation.MovieList.Count];
            for(int i=0;i<Operation.MovieList.Count;i++)
            {
                MovieDetail[i]=Operation.MovieList[i].MovieId+","+Operation.MovieList[i].MovieName+","+Operation.MovieList[i].Language;
            }
            File.WriteAllLines("MovieTicket/MovieDetails.csv",MovieDetail);

            string[] TheatreDetail=new string[Operation.TheatreList.Count];
            for(int i=0;i<Operation.TheatreList.Count;i++)
            {
                TheatreDetail[i]=Operation.TheatreList[i].TheatreId+","+Operation.TheatreList[i].TheatreName+","+Operation.TheatreList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicket/TheatreDetails.csv",TheatreDetail);


        }
    }
}
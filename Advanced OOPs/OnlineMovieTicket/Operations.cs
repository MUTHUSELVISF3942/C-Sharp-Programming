using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
   public delegate void EventManager();
    public class Operation
    {
        public static event EventManager eventlink=null;
        
        static UserDetails currentUser=null;

        //Creating list
       public static List<UserDetails> UserList=new List<UserDetails>();
       public static List<BookingDetails> BookingList=new List<BookingDetails>();
       public static List<TheatreDetails> TheatreList=new List<TheatreDetails>();
       public static List<MovieDetails> MovieList=new List<MovieDetails>();
       public static List<ScreeningDetails> ScreeningList=new List<ScreeningDetails>();
        
        //Event

        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(Operation.DefaultData);
            eventlink+=new EventManager(Operation.MainMenu);
            eventlink+=new EventManager(Files.WriteFile);
        }
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
        //Main Menu
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option\n1.User Registration\n2.Login\n3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("**********User Registration**********");
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("***********Login**************");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("************Exit Mainmenu************");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        //Customer Registration
        public static void CustomerRegistration()
        {
            System.Console.WriteLine("Enter the name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the phone number:");
            long phoneNumber=long.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(name,age,phoneNumber);
            UserList.Add(user);
            System.Console.WriteLine("Registration successfully...\t User Id:"+user.UserId);
        }

        //Customer Login
        public static void Login()
        {
            System.Console.WriteLine("Enter the user id:");
            string userId=Console.ReadLine().ToUpper();
            int flag=1;
            foreach(UserDetails user in UserList)
            {
                if(userId==user.UserId)
                {
                    System.Console.WriteLine("Login successfully...");
                    currentUser=user;
                    SubMenu();
                    flag=0;
                }
            }
            if(flag==1)
            {
                System.Console.WriteLine("Invalid id");
            }
        }


        //Submenu
        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option\n1.Ticket Booking\n2.Ticket Cancellation\n3.Booking History\n4.Wallet Recharge\n5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("************Ticket Booking**********");
                        TicketBooking();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("************Ticket Cancellation*********");
                        TicketCancellation();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("***********Booking History*************");
                        BookingHistory();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("************Wallet Recharge**********");
                        currentUser.RechargeWallet();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("**********Exit Submenu***********");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        //Ticket Booking
    public static void TicketBooking()
    {
        
            //Show the list of theatre's details
            foreach(TheatreDetails theatre in TheatreList)
            {
                System.Console.WriteLine("Theatre ID:"+theatre.TheatreId+"\tTheatre Name:"+theatre.TheatreName+"\tTheatre Location:"+theatre.TheatreLocation);
                //Get the theatre id
            }
            System.Console.WriteLine("Enter the theatre id:");
            string theatreId=Console.ReadLine().ToUpper();
            
            //Show the list of movie in the theatre of screening list
            foreach(ScreeningDetails screen in ScreeningList)
            {
            
                if(theatreId==screen.TheatreId)
                {
                    
                    //Get the movie from list of screen movie using movie id
                    foreach(MovieDetails movie in MovieList)
                    {
                        
                        System.Console.WriteLine("Movie ID:"+movie.MovieId+"\tMovie Name:"+movie.MovieName+"\tMovie Language:"+movie.Language);
                    }
                    System.Console.WriteLine("Enter the movie id:");
                    string movieId=Console.ReadLine().ToUpper();
                    if(movieId==screen.MovieId)
                    {
                    //Get the count of seat to book
                        System.Console.WriteLine("Enter the seat count to book:");
                        int seatCount=int.Parse(Console.ReadLine());
                        
                        //Check the seat count
                        if(screen.NoOfSeatsAvailable<seatCount)
                        {
                            System.Console.WriteLine("Required seat count not available..Count availbility is"+screen.NoOfSeatsAvailable);
                        }
                        else
                        {
                        //Calculate the total amount
                            int amount=seatCount*screen.TicketPrice;
                            int gst=(18*amount)/100;
                            int Total=amount+gst;
                            //Check the current user wallet balance
                        
                            if(Total>currentUser.WalletBalance)
                            {
                                //Insufficient balance.. Please recharge wallet
                                System.Console.WriteLine("Insufficient wallet balance...Please recharge wallet");
                                currentUser.RechargeWallet();
                            }
                            else
                            {
                                    //Sufficient balance..Deduct the current user wallet balance and deduct the seat availability
                                currentUser.WalletBalance-=Total;
                                
                                screen.NoOfSeatsAvailable-=seatCount;
                                
                            }
                            BookingDetails book=new BookingDetails(currentUser.UserId,movieId,theatreId,seatCount,Total,BookingStatus.Booked);
                            BookingList.Add(book);

                            System.Console.WriteLine("Ticket booked successfully...");
                            break;   
                        } 
                    }     
                       
                }
                    

            }
           
        }
           
            
   

        //Ticket Cancellation
        public static void TicketCancellation()
        {
            //Show the booking history in current user
            foreach(BookingDetails booking in BookingList)
            {
                if(booking.UserId.Equals(currentUser.UserId))
                {
                    System.Console.WriteLine("Booking ID:"+booking.BookingId+"\tUser ID:"+currentUser.UserId+"\tMovie ID:"+booking.MovieId+"\tTheatre ID:"+booking.TheatreId+"\tSeat Count:"+booking.SeatCount+"\tTotal Amount:"+booking.TotalAmount+"\tBooking Status:"+booking.BookingStatus);
                }
            }

            //Get the booking id
            System.Console.WriteLine("Enter the booking id:");
            string bookingId=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Do you want to cancel:");
            string cancel=Console.ReadLine();
            if(cancel=="yes")
            {
                 //Check the booking status
                 foreach(BookingDetails book in BookingList)
                 {
                    if(book.BookingStatus==BookingStatus.Booked)
                    {
                        //Get the count of seat booking from history and increase seat availability

                        foreach(ScreeningDetails screen in ScreeningList)
                        screen.NoOfSeatsAvailable+=book.SeatCount;

                        //Reduce 20Rs from total amount and remaining amount wallet balance

                        int total=book.TotalAmount-20;
                        currentUser.WalletBalance+=total;

                        //Change booking status cancelled

                        if(book.BookingId==bookingId)
                        {
                            book.BookingStatus=BookingStatus.Cancelled;
                        }
                    }
                 }
                 System.Console.WriteLine("Booking Cancelled successfully.....");
                 foreach(BookingDetails booking in BookingList)
                 {
                    if(booking.UserId.Equals(currentUser.UserId))
                    {
                        System.Console.WriteLine("Booking ID:"+booking.BookingId+"\tUser ID:"+currentUser.UserId+"\tMovie ID:"+booking.MovieId+"\tTheatre ID:"+booking.TheatreId+"\tSeat Count:"+booking.SeatCount+"\tTotal Amount:"+booking.TotalAmount+"\tBooking Status:"+booking.BookingStatus);
                    }
                }
            }
           
          
        }

        //Booking History
        public static void BookingHistory()
        {
            //Show the current user booking history

            foreach(BookingDetails booking in BookingList)
            {
                if(booking.UserId.Equals(currentUser.UserId))
                {
                    System.Console.WriteLine("Booking ID:"+booking.BookingId+"\tUser ID:"+currentUser.UserId+"\tMovie ID:"+booking.MovieId+"\tTheatre ID:"+booking.TheatreId+"\tSeat Count:"+booking.SeatCount+"\tTotal Amount:"+booking.TotalAmount+"\tBooking Status:"+booking.BookingStatus);
                }
            }
        }

        //Default data
        public static void DefaultData()
        {
            //User details 
            UserList.Add(new UserDetails("Ravichandran",30,8599988032));
            UserList.Add(new UserDetails("Baskaran",30,6949269231));

            //Theatre details 
            TheatreList.Add(new TheatreDetails("Inox","Anna Nagar"));
            TheatreList.Add(new TheatreDetails("Ega Theatre","Chetpet"));
            TheatreList.Add(new TheatreDetails("Kamala","Vadapalani"));

            //Movie details
            MovieList.Add(new MovieDetails("Bahubali 2","Telugu"));
            MovieList.Add(new MovieDetails("Ponniyin Selvan","Tamil"));
            MovieList.Add(new MovieDetails("Cobra","Tamil"));
            MovieList.Add(new MovieDetails("Vikram","Hindi(Dubbed)"));
            MovieList.Add(new MovieDetails("Vikram","Tamil"));
            MovieList.Add(new MovieDetails("Beast","English"));

            //Screening details
            ScreeningList.Add(new ScreeningDetails("MID501","TID301",200,5));
            ScreeningList.Add(new ScreeningDetails("MID502","TID301",300,2));
            ScreeningList.Add(new ScreeningDetails("MID506","TID301",50,1));
            ScreeningList.Add(new ScreeningDetails("MID501","TID302",400,5));
            ScreeningList.Add(new ScreeningDetails("MID502","TID302",300,20));
            ScreeningList.Add(new ScreeningDetails("MID504","TID302",500,2));
            ScreeningList.Add(new ScreeningDetails("MID505","TID303",100,11));
            ScreeningList.Add(new ScreeningDetails("MID502","TID303",200,20));
            ScreeningList.Add(new ScreeningDetails("MID504","TID303",350,2));

            //Booking details
            BookingList.Add(new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked));
            BookingList.Add(new BookingDetails("UID1001","MID504","TID302",1,400,BookingStatus.Booked));
            BookingList.Add(new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked));
        }
    }
}
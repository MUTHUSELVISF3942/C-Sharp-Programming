using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
    public class MovieDetails
    {
        private static int s_movieId=500;
        public string MovieId{get;}
        public string MovieName { get;set;}
        public string Language { get;set;}
        /// <summary>
        /// Create constructor in movie details
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="language"></param>
        public MovieDetails(string movieName,string language)
        {
            s_movieId++;
            MovieId="MID"+s_movieId;
            MovieName=movieName;
            Language=language;
        }
        public MovieDetails(string data)
        {
            string[] value=data.Split(",");
            s_movieId=int.Parse(value[0].Remove(0,3));
            MovieId=value[0];
            MovieName=value[1];
            Language=value[2];
        }
        
    }
}
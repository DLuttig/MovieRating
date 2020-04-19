using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        public static int movieCount = 0;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
            movieCount++;
        }

        public int getMovieCount()
        {
            return movieCount;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}

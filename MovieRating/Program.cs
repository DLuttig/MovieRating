using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Console.WriteLine(Movie.movieCount);
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(Movie.movieCount);



            Console.WriteLine(avengers.title + " -- " + avengers.Rating + " -- " + avengers.getMovieCount());


            Console.ReadLine();

        }
    }
}

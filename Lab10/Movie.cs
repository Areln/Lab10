using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Movie
    {
        private string movieTitle;
        private string movieGenre;

        public string MovieTitle { get { return movieTitle; } set { movieTitle = value; } }
        public string MovieGenre { get { return movieGenre; } set { movieGenre = value; } }

        public Movie(string _movieTitle, string _movieGenre) 
        {
            movieTitle = _movieTitle;
            movieGenre = _movieGenre;
        }
        public override string ToString()
        {
            return $"Movie Title: {MovieTitle}, Movie Genre: {MovieGenre}";
        }
        public static void PrintMoviesByGenre(List<Movie> movies, string genre) 
        {
            foreach (Movie item in movies)
            {
                if (item.MovieGenre == genre) 
                {
                    Console.WriteLine(item.ToString());
                } 
            }
        }
        public static List<string> GetMovieGenres(List<Movie> movies)
        {
            List<string> movieGenres = new List<string>();
            foreach (Movie movie in movies)
            {
                if (!movieGenres.Contains(movie.MovieGenre))
                {
                    movieGenres.Add(movie.MovieGenre);
                }
            }
            return movieGenres;
        }
    }
}

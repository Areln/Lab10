using System;
using System.Collections.Generic;


namespace Lab10
{
    class Program
    {
        static string exiting = "n";
        static void Main(string[] args)
        {

            List<Movie> Movies = new List<Movie>()
            {
                new Movie("Harry Potter", "Fantasy"),
                new Movie("Lord of Rings", "Fantasy"),
                new Movie("Iron Man", "SuperHero"),
                new Movie("Spider Man", "SuperHero"),
                new Movie("John Wick", "Action"),
                new Movie("The Matrix", "Action"),
                new Movie("The Land Before Time", "Animation"),
                new Movie("The Lion King", "Animation"),
                new Movie("Us", "Horror"),
                new Movie("It", "Horror"),
                new Movie("Step Brothers", "Comedy"),
                new Movie("Anchorman", "Comedy")
            };
            
            while (exiting != "y")
            {
                PrompUser(Movies);
                Rerun();
            }

        }
        static void Rerun()
        {
            exiting = GetInput("Would you like to exit?(y/n): ");
        }
        static void PrompUser(List<Movie> movies) 
        {
            List<string> movieGenres = Movie.GetMovieGenres(movies);
            string genreMessage = "";
            for (int i = 0; i < movieGenres.Count; i++)
            {
                genreMessage = string.Concat(genreMessage, $"{i+1}) {movieGenres[i]}\n");
            }
            Console.WriteLine("Select A Genre:");
            Movie.PrintMoviesByGenre(movies, movieGenres[ParseIntFromString(genreMessage)]);
        }
        static string GetInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (input == "")
            {
            Console.WriteLine("Input cannot be blank");
                return GetInput(message);
            }
            else
            {
                return input;
            }
        }
        static int ParseIntFromString(string message)
        {
            try
            {
                return int.Parse(GetInput(message))-1;
            }
            catch
            {
                Console.WriteLine("Something went wrong, please try again: ");
                return ParseIntFromString(message);
            }
        }
    }
}


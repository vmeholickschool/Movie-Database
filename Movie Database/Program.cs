using Movie_Database;
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();

        movies.Add(new Movie("Despicable Me", "Animated"));
        movies.Add(new Movie("Ratatouille", "Animated"));
        movies.Add(new Movie("Gone Girl", "Drama"));
        movies.Add(new Movie("Reptile", "Drama"));
        movies.Add(new Movie("Smile", "Horror"));
        movies.Add(new Movie("Nope", "Horror"));
        movies.Add(new Movie("Silence of the Lambs", "Horror"));
        movies.Add(new Movie("Blade Runner", "SciFi"));
        movies.Add(new Movie("Inception", "SciFi"));
        movies.Add(new Movie("Reminiscence", "SciFi"));

        Console.WriteLine("Welcome to the Movie List Application!\n ");
        Console.WriteLine("There are 15 movies in this list. \n");

        while (true)
        {
            Console.WriteLine("What category are you interested in? or write 'exit' to exit application ");
            Console.WriteLine("Animated");
            Console.WriteLine("Drama");
            Console.WriteLine("Horror ");
            Console.WriteLine("SciFi");

            string userChoice = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (userChoice == "exit")
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }

            List<Movie> filteredMovies = movies.FindAll(x => x.Category.ToLower() == userChoice);

            Console.WriteLine("Movies in the selected category:");
            if (filteredMovies.Count > 0)
            {
                foreach (Movie movie in filteredMovies)
                {
                    Console.WriteLine(movie.DisplayCategories());
                }
            }
            else
            {
                Console.WriteLine("No movies found in the selected category.");
            }

            Console.WriteLine();
        }
    }
}
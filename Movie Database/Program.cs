using Movie_Database;
using System.Runtime.CompilerServices;

internal class Program
{
    public static string x { get; private set; }

    private static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();

        movies.Add(new("Despicable Me", "Animated"));
        movies.Add(new("Ratatouille", "Animated"));
        movies.Add(new("Gone Girl", "Drama"));
        movies.Add(new("Reptile", "Drama"));
        movies.Add(new("Smile", "Horror"));
        movies.Add(new("Nope", "Horror"));
        movies.Add(new("Silence of the Lambs", "Horror"));
        movies.Add(new("Blade Runner", "SciFi"));
        movies.Add(new("Inception", "SciFi"));
        movies.Add(new("Reminiscence", "SciFi"));


        Console.WriteLine("Welcome to the Movie List Application!\n ");
        Console.Write("There are 15 movies in this list. \n");

        while (true)
        {
            Console.WriteLine("What category are you interested in? ");
            Console.WriteLine("Animated");
            Console.WriteLine("Drama");
            Console.WriteLine("Horror ");
            Console.WriteLine("SciFi");
            

            string userChoice = Console.ReadLine();
            Console.WriteLine();



            List<Movie> filteredMovies = movies.FindAll(x => x.Category.Equals(userChoice));
            

            Console.WriteLine();



        }
    }
}
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
            Console.WriteLine(" 1. Animated");
            Console.WriteLine("2. Drama");
            Console.WriteLine("3. Horror ");
            Console.WriteLine("4. SciFi");
            

            string userChoice = Console.ReadLine();
            Console.WriteLine();



            List<Movie> animatedMovies = movies.FindAll(x => x.Equals("1. Animated"));
            List<Movie> dramaMovies = movies.FindAll(x => x.Equals("2. Drama"));
            List<Movie> horrorMovies = movies.FindAll(x => x.Equals("3. Horror"));
            List<Movie> sciFiMovies = movies.FindAll(x => x.Equals("4. SciFi"));

            Console.WriteLine(animatedMovies);



        }
    }
}
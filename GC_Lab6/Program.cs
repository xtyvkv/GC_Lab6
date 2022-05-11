using System;
using System.Collections.Generic;
using System.Linq;
 
// TO DO - make category an int, and convert
// print out category list and let user select by number
// avoid all of the else ifs where you type out each category twice?

namespace GC_Lab6
{
    public class Movie
    {
        public string Title {  get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            bool goAgain = true;
            List<Movie> movieList = new List<Movie>();

            // add movies
            movieList.Add(new Movie() { Title = "Spirited Away", Category = "Animated" });
            movieList.Add(new Movie() { Title = "The Matrix", Category = "Sci-Fi" });
            movieList.Add(new Movie() { Title = "Blade", Category = "Sci-Fi" });
            movieList.Add(new Movie() { Title = "Step Brothers", Category = "Comedy" });
            movieList.Add(new Movie() { Title = "Hereditary", Category = "Horror" });
            movieList.Add(new Movie() { Title = "The Lord of the Rings", Category = "Fantasy" });
            movieList.Add(new Movie() { Title = "Paris Is Burning", Category = "Documentary" });
            movieList.Add(new Movie() { Title = "Face Off", Category = "Action" });
            movieList.Add(new Movie() { Title = "Groundhog Day", Category = "Romantic Comedy" });
            movieList.Add(new Movie() { Title = "The Exorcist", Category = "Horror" });

            // just for fun, messin around
            /*
            // print movie list out with all info
            Console.WriteLine();
            foreach (Movie movie in movieList)
            {
                Console.WriteLine(movie);
            }

            // sort movies by genre (a-z)
            Console.WriteLine();
            foreach (Movie movie in movieList.OrderBy(x => x.Category))
            {
                Console.WriteLine(movie);
            }
            */

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine($"There are {movieList.Count} movies in this list.");
            while (goAgain == true)
            {
                Console.Write("What category are you interested in? ");

                // print category list
                /*
                Console.WriteLine(
                    "Animated\n" +
                    "Sci-Fi\n" +
                    "Comedy\n" +
                    "Horror\n" +
                    "Fantasy\n" +
                    "Documentary\n" +
                    "Action\n" +
                    "Romantic Comedy\n");
                */
                string categoryChoice = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(categoryChoice))
                {
                    Console.WriteLine("Invalid input.");
                }
                else if (string.Equals(categoryChoice, "Animated", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Animated")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Sci-Fi", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Sci-Fi")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Comedy", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Comedy")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Horror", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Horror")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Fantasy", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Fantasy")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Documentary", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Documentary")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Action", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Action")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else if (string.Equals(categoryChoice, "Romantic Comedy", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Romantic Comedy")
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("I don't have that category.");
                }

                Console.WriteLine();
                Console.Write("Continue (y/n)? ");
                string goAgainInput = Console.ReadLine().ToLower();
                if (goAgainInput == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                else if (goAgainInput =="n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Goodbye!");
                    break;
                }
            }
        }
    }
}
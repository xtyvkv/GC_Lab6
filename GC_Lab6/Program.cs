using System;
using System.Collections.Generic;
using System.Linq;
 
// TO DO - make category an int, and convert
// print out category list and let user select by number
// avoid all of the else ifs where you type out each category twice

namespace GC_Lab6
{
    public class Movie
    {
        public string Title {  get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return "Title: " + Title + " // Genre: " + Category;
        }

        /*
        public override bool Equals( object obj )
        {
            if (obj == null) return false;
            Movie objAsMovie = obj as Movie;
            if (objAsMovie == null) return false;
            else return Equals(objAsMovie);
        }
        public bool Equals(Movie other)
        {
            if (other == null) return false;
            return (this.GenreID.Equals(other.GenreID));
        }
        */
    }
    internal class Program
    {
        static void Main( string[] args )
        {
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

            Console.WriteLine();

            // print sci-fi movies
            foreach (Movie movie in movieList)
            {
                if (movie.Category == "Sci-Fi")
                {
                    Console.WriteLine(movie);
                }
            }

            Console.WriteLine();
            */

            // ask user to enter category
            // just make this into an array to easily print out
            Console.WriteLine("Please choose a category:\n" +
                "Animated\n" +
                "Sci-Fi\n" +
                "Comedy\n" +
                "Horror\n" +
                "Fantasy\n" +
                "Documentary\n" +
                "Action\n" +
                "Romantic Comedy\n");
            string categoryChoice = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(categoryChoice))
            {
                Console.WriteLine("Invalid input.");
            }
            else if (categoryChoice == "Animated")
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
                Console.WriteLine("I don't have that category.");
        }
    }
}
using System;
using System.Collections.Generic;

namespace Day4___Video_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;

            string[] menuItems =
            {
                "Show all movies",
                "Add a movie",
                "Delete movie",
                "Edit movie",
                "Exit"

            };

            

            selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List of movies: \n");
                        showMovies();
                        break;
                    case 2:
                        Console.WriteLine("Add a movie");
                        break;
                    case 3:
                        Console.WriteLine("Delete movie");
                        break;
                    case 4:
                        Console.WriteLine("Edit movie");
                        break;
                    default:
                        break;

                }
                selection = ShowMenu(menuItems);

            }
            Console.WriteLine("Bye bye");

            Console.ReadLine();
            


        }

        private static void showMovies()
        {
            List<Movie> movies = new List<Movie>();
            {
                movies.Add(new Movie()
                {
                    Name = "Godfather",
                    Year = "1994"
                });
                movies.Add(new Movie()
                {
                    Name = "Godfather",
                    Year = "1994"
                });

                foreach (var movie in movies)
                {
                    Console.WriteLine($" Name = {movie.Name} Year = {movie.Year}");
                }
                
            }
        }

        private static int ShowMenu(string[] menuItems)
        {
            
            Console.WriteLine("Select where you wanna go! \n");



            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + menuItems[i]);
            }
            //Console.ReadLine();

            int selection;

            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("You need to select a number between 1-5");
            }
            Console.WriteLine("selection: " + selection);
            return selection;
        }
    }
}
    



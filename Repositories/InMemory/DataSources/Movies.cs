using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Repositories.InMemory.DataSources
{
    public static class Movies
    {
        public static readonly List<Movie> MovieList;

        static Movies()
        {
            MovieList = new List<Movie> {
                new Movie { Id = 1, Title = "Dragon Ball Z: Broly - Second Coming", YearOfRelease = 1994, RunningTime = 62, Genres = new List<string> {"Action", "Adventure"}},
                new Movie { Id = 2, Title = "Dragon Ball Z: Bio Broly", YearOfRelease = 1994, RunningTime = 50, Genres = new List<string> {"Comedy", "Adventure"}},
                new Movie { Id = 3, Title = "Dragon Ball Z: The Legendary Super Saiyan", YearOfRelease = 1993, RunningTime = 80, Genres = new List<string> {"Fight", "Adventure"}},
                new Movie { Id = 4, Title = "Dragon Ball Super: Broly", YearOfRelease = 2018, RunningTime = 101, Genres = new List<string> {"Action", "Adventure", "Comedy"}},
                new Movie { Id = 5, Title = "Fight Club", YearOfRelease = 1999, RunningTime = 151, Genres = new List<string> {"Action", "Thriller", "Comedy"}},
                new Movie { Id = 6, Title = "Star Wars: The Last Jedi", YearOfRelease = 2017, RunningTime = 152, Genres = new List<string> {"Action", "Science Fiction", "Comedy"}},
            };
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using MovieApi.Models;
using MovieApi.Repositories.InMemory.DataSources;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories.InMemory
{
    public class InMemoryMovieRepository : IMovieRepository
    {
        public IEnumerable<Movie> SearchMovies(string title, string[] genres, int year)
        {
            return Movies.MovieList.Where(m => (title != null && m.Title.Contains(title)) || m.YearOfRelease == year || m.Genres.Any(g => genres.Contains(g)));
        }

        public IEnumerable<Movie> GetMovies()
        {
            return Movies.MovieList;
        }

        public bool MovieExists(int id)
        {
            return Movies.MovieList.Exists(m => m.Id == id);
        }
    }
}
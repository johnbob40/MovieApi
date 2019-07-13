using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> SearchMovies(string title, string[] genre, int year);
        IEnumerable<Movie> GetMovies();
        bool MovieExists(int id);
    }
}
using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> SearchMovies(string[] genres, string title, int yearOfRelease);
        IEnumerable<Movie> SelectTopFiveMovies();
        IEnumerable<Movie> SelectTopFiveMoviesByUser(int id);
        bool MovieExists(int id);
        void InsertOrUpdateMovieRating(MovieRating rating);
    }
}
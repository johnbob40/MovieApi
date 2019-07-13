using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Repositories.Interfaces
{
    public interface IMovieRatingRepository
    {
        IEnumerable<MovieRating> GetRatingsByUserId(int id);
        IEnumerable<MovieRating> GetRatingsByMovieId(int id);
        IEnumerable<MovieRating> GetRatings();
        void InsertOrUpdateMovieRating(MovieRating rating);
    }
}
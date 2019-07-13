using System.Collections.Generic;
using System.Linq;
using MovieApi.Models;
using MovieApi.Repositories.InMemory.DataSources;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories.InMemory
{
    public class InMemoryMovieRatingRepository : IMovieRatingRepository
    {
        public IEnumerable<MovieRating> GetRatingsByUserId(int id)
        {
            return MovieRatings.MovieRatingsList.Where(m => m.UserId == id);
        }

        public IEnumerable<MovieRating> GetRatings()
        {
            return MovieRatings.MovieRatingsList;
        }

        public IEnumerable<MovieRating> GetRatingsByMovieId(int id)
        {
            return MovieRatings.MovieRatingsList.Where(m => m.MovieId == id);
        }

        public void InsertOrUpdateMovieRating(MovieRating rating)
        {
            var existingRating = MovieRatings.MovieRatingsList.FirstOrDefault(m => m.MovieId == rating.MovieId && m.UserId == rating.UserId);
            if (existingRating != null)
                existingRating.Rating = rating.Rating;
            else
                MovieRatings.MovieRatingsList.Add(rating);
        }
    }
}
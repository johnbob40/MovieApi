using System.Collections.Generic;
using System.Linq;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRatingRepository _movieRatingRepository;
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository, IMovieRatingRepository movieRatingRepository)
        {
            _movieRatingRepository = movieRatingRepository;
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> SearchMovies(string[] genres, string title, int yearOfRelease)
        {
            return _movieRepository.SearchMovies(title, genres, yearOfRelease).Select(m =>
            {
                var ratings = _movieRatingRepository.GetRatingsByMovieId(m.Id);
                m.AverageRating = ratings.Average(r => r.Rating);
                return m;
            });
        }

        public IEnumerable<Movie> SelectTopFiveMovies()
        {
            var averageRatings = _movieRatingRepository.GetRatings()
            .GroupBy(m => m.MovieId)
            .Select(g => new MovieRating { MovieId = g.Key, Rating = g.Average(r => r.Rating) });

            return SortTopMovies(averageRatings).Take(5);
        }

        public IEnumerable<Movie> SelectTopFiveMoviesByUser(int id)
        {
            var ratings = _movieRatingRepository.GetRatingsByUserId(id);

            return SortTopMovies(ratings).Take(5);
        }

        public bool MovieExists(int id)
        {
            return _movieRepository.MovieExists(id);
        }

        public void InsertOrUpdateMovieRating(MovieRating rating)
        {
            _movieRatingRepository.InsertOrUpdateMovieRating(rating);
        }

        private IEnumerable<Movie> SortTopMovies(IEnumerable<MovieRating> ratings)
        {
            return _movieRepository.GetMovies()
                .Join(ratings,
                    movie => movie.Id,
                    rating => rating.MovieId,
                    (movie, rating) => new Movie
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        RunningTime = movie.RunningTime,
                        AverageRating = rating.Rating,
                        YearOfRelease = movie.YearOfRelease
                    })
                .OrderByDescending(m => m.AverageRating)
                .ThenBy(m => m.Title);
        }
    }
}
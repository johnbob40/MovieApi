using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Repositories.InMemory.DataSources
{
    public static class MovieRatings
    {
        public static readonly List<MovieRating> MovieRatingsList;

        static MovieRatings()
        {
            MovieRatingsList = new List<MovieRating>
            {
                new MovieRating { MovieId = 1, UserId = 1, Rating = 2 },
                new MovieRating { MovieId = 1, UserId = 2, Rating = 2 },
                new MovieRating { MovieId = 1, UserId = 3, Rating = 2 },
                new MovieRating { MovieId = 1, UserId = 4, Rating = 1 },
                new MovieRating { MovieId = 1, UserId = 5, Rating = 1 },
                new MovieRating { MovieId = 1, UserId = 6, Rating = 1 },
                new MovieRating { MovieId = 2, UserId = 1, Rating = 1 },
                new MovieRating { MovieId = 2, UserId = 2, Rating = 2 },
                new MovieRating { MovieId = 2, UserId = 3, Rating = 2 },
                new MovieRating { MovieId = 2, UserId = 4, Rating = 1 },
                new MovieRating { MovieId = 2, UserId = 5, Rating = 2 },
                new MovieRating { MovieId = 2, UserId = 6, Rating = 1 },
                new MovieRating { MovieId = 3, UserId = 1, Rating = 2 },
                new MovieRating { MovieId = 3, UserId = 2, Rating = 2 },
                new MovieRating { MovieId = 3, UserId = 3, Rating = 3 },
                new MovieRating { MovieId = 3, UserId = 4, Rating = 3 },
                new MovieRating { MovieId = 3, UserId = 5, Rating = 3 },
                new MovieRating { MovieId = 3, UserId = 6, Rating = 3 },
                new MovieRating { MovieId = 4, UserId = 1, Rating = 5 },
                new MovieRating { MovieId = 4, UserId = 2, Rating = 5 },
                new MovieRating { MovieId = 4, UserId = 3, Rating = 5 },
                new MovieRating { MovieId = 4, UserId = 4, Rating = 5 },
                new MovieRating { MovieId = 4, UserId = 5, Rating = 5 },
                new MovieRating { MovieId = 4, UserId = 6, Rating = 5 },
                new MovieRating { MovieId = 5, UserId = 1, Rating = 4 },
                new MovieRating { MovieId = 5, UserId = 2, Rating = 5 },
                new MovieRating { MovieId = 5, UserId = 3, Rating = 5 },
                new MovieRating { MovieId = 5, UserId = 4, Rating = 5 },
                new MovieRating { MovieId = 5, UserId = 5, Rating = 5 },
                new MovieRating { MovieId = 5, UserId = 6, Rating = 4 },
                new MovieRating { MovieId = 6, UserId = 1, Rating = 5 },
                new MovieRating { MovieId = 6, UserId = 2, Rating = 5 },
                new MovieRating { MovieId = 6, UserId = 3, Rating = 1 },
                new MovieRating { MovieId = 6, UserId = 4, Rating = 1 },
                new MovieRating { MovieId = 6, UserId = 5, Rating = 1 },
            };
        }
    }
}
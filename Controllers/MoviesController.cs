using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using MovieApi.Services;
using Microsoft.AspNetCore.Http;
using MovieApi.ApiResponses;

namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IUserService _userService;

        public MoviesController(IMovieService movieService, IUserService userService)
        {
            _movieService = movieService;
            _userService = userService;
        }

        [HttpGet("top")]
        [ProducesResponseType(typeof(IEnumerable<Movie>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var movies = _movieService.SelectTopFiveMovies();

            return Ok(MapToResponse(movies));
        }

        [HttpGet("top/user")]
        [ProducesResponseType(typeof(IEnumerable<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get([FromQuery] int id)
        {
            if (id == default(int))
                return BadRequest();

            if (!_userService.UserExists(id))
            {
                return NotFound();
            }

            var movies = _movieService.SelectTopFiveMoviesByUser(id);

            return Ok(MapToResponse(movies));
        }

        [HttpGet("search")]
        [ProducesResponseType(typeof(IEnumerable<Movie>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get([FromQuery] string title, [FromQuery] int yearOfRelease, [FromQuery] params string[] genre)
        {
            if (title == null && yearOfRelease == default(int) && (genre == null || genre.Length == 0))
                return BadRequest();

            var movies = _movieService.SearchMovies(genre, title, yearOfRelease);

            if (movies.Count() == 0)
                return NotFound();

            return Ok(MapToResponse(movies));
        }

        [HttpPost("rating")]
        public IActionResult Post([FromBody] MovieRating rating)
        {
            if (rating.Rating > 5 || rating.Rating < 1)
                return BadRequest();
            if (!_movieService.MovieExists(rating.MovieId) || !_userService.UserExists(rating.UserId))
                return NotFound();

            _movieService.InsertOrUpdateMovieRating(rating);
            return Ok();
        }

        private IEnumerable<MovieResponse> MapToResponse(IEnumerable<Movie> movies)
        {
            return movies.Select(m =>
                new MovieResponse
                {
                    AverageRating = Math.Round(m.AverageRating * 2, MidpointRounding.AwayFromZero) / 2,
                    Id = m.Id,
                    YearOfRelease = m.YearOfRelease,
                    Title = m.Title,
                    RunningTime = m.RunningTime
                }
            );
        }
    }
}

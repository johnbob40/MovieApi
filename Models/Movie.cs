using System.Collections.Generic;

namespace MovieApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public int RunningTime { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public decimal AverageRating { get; set; }
    }
}
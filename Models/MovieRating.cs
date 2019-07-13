namespace MovieApi.Models
{
    public class MovieRating
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public decimal Rating { get; set; }
    }
}
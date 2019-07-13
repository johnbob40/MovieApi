namespace MovieApi.ApiResponses
{
    public class MovieResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public int RunningTime { get; set; }
        public decimal AverageRating { get; set; }
    }
}
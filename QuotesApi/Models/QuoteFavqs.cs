namespace QuotesApi.Models
{
    public class QuoteFavqs
    {
        public DateTime Qotd_Date { get; set; }
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Body { get; set; }
        public bool? Favorite { get; set; } = false;
        public string? Url { get; set; }
        public string? author_permalink { get; set; }
    }
}
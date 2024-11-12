namespace API.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Image>? Images { get; set; } = new List<Image>();
        public string Body { get; set; } 
        public string AuthorId { get; set; }
        public int Views { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();

    }
}

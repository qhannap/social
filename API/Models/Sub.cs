namespace API.Models
{
    public class Sub
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Post>? Posts { get; set; } = new List<Post>(); 
    }
}

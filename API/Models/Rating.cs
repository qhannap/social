namespace API.Models
{
    public class Rating

    {
        public Post Id { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }

}

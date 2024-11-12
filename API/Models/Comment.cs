using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }






    }

}

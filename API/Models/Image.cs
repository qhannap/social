using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl {  get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}

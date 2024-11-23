using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SocialContext : DbContext
    {
        public SocialContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Sub> Subs { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}

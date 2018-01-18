using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Entities
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions<HomeContext> options) : base(options)
        {
        }

        public DbSet<Post> RedditPosts { get; set; }
        public DbSet<User> RedditUsers { get; set; }
    }
}

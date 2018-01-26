using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using RedditBackend.Models;

namespace RedditBackend.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VoteClass> Votes { get; set; }
    }
}

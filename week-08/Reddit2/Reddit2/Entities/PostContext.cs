using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Reddit2.Models;

namespace Reddit2.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

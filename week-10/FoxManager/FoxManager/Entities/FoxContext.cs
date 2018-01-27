using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using FoxManager.Models;

namespace FoxManager.Entities
{
    public class FoxContext : DbContext
    {
        public FoxContext(DbContextOptions<FoxContext> options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Models.TaskClass> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}

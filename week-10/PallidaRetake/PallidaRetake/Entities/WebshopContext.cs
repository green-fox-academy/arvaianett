using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using PallidaRetake.Models;

namespace PallidaRetake.Entities
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Clothes> Webshop { get; set; }
    }
}

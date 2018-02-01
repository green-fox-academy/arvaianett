using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Quiz.Models;

namespace Quiz.Entities
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<QuizModel> QuizModels { get; set; }
    }
}

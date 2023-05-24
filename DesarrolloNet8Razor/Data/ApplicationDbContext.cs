using DesarrolloNet8Razor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DesarrolloNet8Razor.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action", displayOrder = 1 },
                new Category { CategoryId = 2, Name = "Sci-fi", displayOrder = 5 },
                new Category { CategoryId = 3, Name = "Horror", displayOrder = 9 }
            );
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Books101.Models;
using Microsoft.AspNetCore.Identity;

namespace Books101.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Books101.Models.Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "User", NormalizedName = "User" },
                new IdentityRole { Id = "2", Name = "Administrator", NormalizedName = "Admin" }
                );
        }
    }
}
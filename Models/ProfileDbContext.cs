using Microsoft.EntityFrameworkCore;

namespace ProfileService.Models
{
    public class ProfileDbContext : DbContext
    {
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options) 
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Activity> Activities { get; set; } 
        public DbSet<Language> Languages { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            base.OnModelCreating(modelBuilder); 
        }
    }
}
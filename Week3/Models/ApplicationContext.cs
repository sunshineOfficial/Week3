namespace HelloAPI.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Billy", Age = 25, IsMarried = true },
            new User { Id = 2, Name = "Van", Age = 18, IsMarried = false },
            new User { Id = 3, Name = "Ivan", Age = 69, IsMarried = true }
        );
    }
}
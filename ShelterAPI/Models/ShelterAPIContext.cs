using Microsoft.EntityFrameworkCore;

namespace ShelterAPI.Models
{
  public class ShelterAPIContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ShelterAPIContext(DbContextOptions<ShelterAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Bob", Species = "dog", Age = 7 },
          new Animal { AnimalId = 2, Name = "Bobbert", Species = "dog", Age = 10 },
          new Animal { AnimalId = 3, Name = "Boboli", Species = "dog", Age = 2 },
          new Animal { AnimalId = 4, Name = "Bob Jovi", Species = "dog", Age = 4 },
          new Animal { AnimalId = 5, Name = "Bobomb", Species = "actual bomb", Age = 22 }
        );
    }
  }
}


using Microsoft.EntityFrameworkCore;
using PetGram.Core.Models;

namespace PetGram.Data;

public class PetShopDbContext(DbContextOptions<PetShopDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>(entityBuilder =>
        {
            entityBuilder
                .HasIndex(p => p.NickName)
                .IsUnique();
        });
        modelBuilder.Entity<Breed>();
        modelBuilder.Entity<Species>();
        modelBuilder.Entity<HealthIssue>();
    }
}

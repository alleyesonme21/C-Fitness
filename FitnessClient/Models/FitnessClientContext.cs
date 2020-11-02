using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace FitnessClient.Models
{
  public class FitnessClientContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }

    public FitnessClientContext(DbContextOptions options) : base(options) { }
  }
}
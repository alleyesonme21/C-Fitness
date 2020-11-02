using Microsoft.EntityFrameworkCore;

namespace Fitness.Models
{
  public class FitnessContext : DbContext
  {
    public FitnessContext(DbContextOptions<FitnessContext> options)
    : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
    builder.Entity<Exercise>()
    .HasData(
        new Exercise { ExerciseId = 1, Name = "Pushups", Difficulty = "Medium", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 2, Name = "Sumo Squats", Difficulty = "Hard", Type = "Strength", Target = "Legs", Calories = 20 },
        new Exercise { ExerciseId = 3, Name = "Bicep Curls", Difficulty = "Easy", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 4, Name = "Situps", Difficulty = "Easy", Type = "Strength", Target = "Core", Calories = 20 },
        new Exercise { ExerciseId = 5, Name = "Plank", Difficulty = "Hard", Type = "Strength", Target = "Core", Calories = 20 },
        new Exercise { ExerciseId = 6, Name = "Squats", Difficulty = "Medium", Type = "Strength", Target = "Legs", Calories = 20 },
        new Exercise { ExerciseId = 7, Name = "Tricep Kickbacks", Difficulty = "Easy", Type = "Strength", Target = "Arms", Calories = 20 }
    );
}
    public DbSet<Exercise> Exercises { get; set; }
 }
}
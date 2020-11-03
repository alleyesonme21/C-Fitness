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
        new Exercise { ExerciseId = 2, Name = "Diamond Pushups", Difficulty = "Hard", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 3, Name = "Yoga Pushups", Difficulty = "Easy", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 4, Name = "Bicep Curls", Difficulty = "Easy", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 5, Name = "Tricep Kickbacks", Difficulty = "Hard", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 6, Name = "Pullups", Difficulty = "Hard", Type = "Strength", Target = "Arms", Calories = 20 },
        new Exercise { ExerciseId = 7, Name = "Arm Circles", Difficulty = "Easy", Type = "Strength", Target = "Arms", Calories = 20 },

        new Exercise { ExerciseId = 8, Name = "Situps", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 9, Name = "Plank", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 10, Name = "Bicycle Crunches", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 11, Name = "Star Crunches", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 12, Name = "100's", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 13, Name = "Russian Twist", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 14, Name = "Oblique Crunches", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },
        new Exercise { ExerciseId = 15, Name = "Side Plank", Difficulty = "Medium", Type = "Strength", Target = "Abs", Calories = 20 },

        new Exercise { ExerciseId = 16, Name = "Sumo Squats", Difficulty = "Medium", Type = "Strength", Target = "Legs", Calories = 20 },
        new Exercise { ExerciseId = 17, Name = "Squats- Narrow Stance", Difficulty = "Medium", Type = "Strength", Target = "Legs", Calories = 20 },
        new Exercise { ExerciseId = 18, Name = "Lunges", Difficulty = "Medium", Type = "Strength", Target = "Legs", Calories = 20 },
        new Exercise { ExerciseId = 19, Name = "Lunges", Difficulty = "Medium", Type = "Strength", Target = "Legs", Calories = 20 },

        new Exercise { ExerciseId = 21, Name = "Glute Kickbacks", Difficulty = "Medium", Type = "Strength", Target = "Glutes", Calories = 20 },
        new Exercise { ExerciseId = 22, Name = "Fire Hydrants", Difficulty = "Medium", Type = "Strength", Target = "Glutes", Calories = 20 },
        new Exercise { ExerciseId = 23, Name = "Frog Kicks", Difficulty = "Medium", Type = "Strength", Target = "Glutes", Calories = 20 },
        new Exercise { ExerciseId = 24, Name = "Hip Thrusts", Difficulty = "Medium", Type = "Strength", Target = "Glutes", Calories = 20 },

        new Exercise { ExerciseId = 25, Name = "Jumping Jacks", Difficulty = "Easy", Type = "Strength", Target = "Cardio", Calories = 20 },
        new Exercise { ExerciseId = 26, Name = "Fly Jacks", Difficulty = "Easy", Type = "Strength", Target = "Cardio", Calories = 20 },
        new Exercise { ExerciseId = 27, Name = "Lunge Jumps", Difficulty = "Hard", Type = "Strength", Target = "Cardio", Calories = 20 },
        new Exercise { ExerciseId = 28, Name = "Mountain Climbers", Difficulty = "Medium", Type = "Strength", Target = "Cardio", Calories = 20 },
        new Exercise { ExerciseId = 29, Name = "High-Knees", Difficulty = "Hard", Type = "Strength", Target = "Cardio", Calories = 20 }
    );
}
    public DbSet<Exercise> Exercises { get; set; }
 }
}
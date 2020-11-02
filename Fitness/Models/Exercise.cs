namespace Fitness.Models
{
  public class Exercise
  {
    public int ExerciseId { get; set; }
    public string Name { get; set; }
    public string Difficulty { get; set; }
    public string Type { get; set; }
    public string Target { get; set; }
    public int Calories { get; set; }
  }
}
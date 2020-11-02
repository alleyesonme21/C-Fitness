using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FitnessClient.Models
{
  public class Exercise
  {
    public int ExerciseId { get; set; }
    public string Name { get; set; }
    public string Difficulty{ get; set; }
    public string Type { get; set; }
    public string Target { get; set; }
    public int Calories { get; set; }

    public virtual ApplicationUser User { get; set; } //allows user to create custom exercise when logged in.

      // get all Exercises
    
  }
}
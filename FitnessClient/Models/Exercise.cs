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

      // get all Exercises
    public static List<Exercise> GetExercises()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      return exerciseList;
    }
    // get one exercise
    public static Exercise GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Exercise exercise = JsonConvert.DeserializeObject<Exercise>(jsonResponse.ToString());
      return exercise;
    }
      public static void Post(Exercise exercise)
      {
        string jsonExercise = JsonConvert.SerializeObject(exercise);
        var apiCallTask = ApiHelper.Post(jsonExercise);
      }
      public static void Put(Exercise exercise)      {
        string jsonExercise = JsonConvert.SerializeObject(exercise);
        var apiCallTask = ApiHelper.Put(exercise.ExerciseId, jsonExercise);
      }
      public static void Delete(int id)
      {
        var apiCallTask = ApiHelper.Delete(id);
      }
  }
}
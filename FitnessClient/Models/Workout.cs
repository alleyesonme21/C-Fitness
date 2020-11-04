using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace FitnessClient.Models
{
  public class Workout
  {
    public Workout() {

      this.Exercises = new List<Exercise>();
    }
    public int WorkoutId { get; set; }
    public ICollection<Exercise> Exercises { get; set; }
    public virtual ApplicationUser User { get; set; } //allows user to create custom exercise when logged in.

   
  
    public static List<Exercise> GetExercises()
    {
      var apiCallTask = ApiHelper.GetAll(); //gives list of every possible exercise
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      return exerciseList;
    }
   
    public static List<Exercise> GetExercisesEasy() //gives a list of 10 easy exercises
    {
      // bool exerciseComplete = false;
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Difficulty).Take(10).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesHard() //gives a list of 10 hard exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Difficulty).Reverse().Take(12).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesMedium() //gives a list of 12 medium exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Difficulty).Skip(5).Take(12).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesAbs() //gives a list of ab exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Target).Take(8).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesArms() //gives a list of ab exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Target).Skip(8).Take(7).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesLegs() //gives a list of ab exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Target).Skip(15).Take(8).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
    public static List<Exercise> GetExercisesCardio() //gives a list of ab exercises
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> exerciseList = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());
      var sortedList = exerciseList.OrderBy(si => si.Target).Skip(21).Take(7).OrderBy(a => Guid.NewGuid()).ToList();
      return sortedList;
    }
      public static void Post(Exercise exercise)
      {
        string jsonExercise = JsonConvert.SerializeObject(exercise);
        var apiCallTask = ApiHelper.Post(jsonExercise);
      }

      public static void Delete(int id)
      {
        var apiCallTask = ApiHelper.Delete(id);
      }
  }
}   
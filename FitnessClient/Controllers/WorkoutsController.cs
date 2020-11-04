using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace FitnessClient.Controllers
{
  public class WorkoutsController : Controller
  {
    public IActionResult Index()
    {
      var allExercises = Workout.GetExercises();
      return View(allExercises);
    }


    public IActionResult EasyWorkout()
    {
      var allExercises = Workout.GetExercisesEasy();
      return View(allExercises);
    }
    public IActionResult MediumWorkout()
    {
      var allExercises = Workout.GetExercisesMedium();
      return View(allExercises);
    }
    public IActionResult HardWorkout()
    {
      var allExercises = Workout.GetExercisesHard();
      return View(allExercises);
    }
    public IActionResult AbsWorkout()
    {
      var allExercises = Workout.GetExercisesAbs();
      return View(allExercises);
    }
    public IActionResult ArmWorkout()
    {
      var allExercises = Workout.GetExercisesArms();
      return View(allExercises);
    }
  public IActionResult LegWorkout()
    {
      var allExercises = Workout.GetExercisesLegs();
      return View(allExercises);
    }
  public IActionResult CardioWorkout()
    {
      var allExercises = Workout.GetExercisesCardio();
      return View(allExercises);
    }





    public IActionResult AddExercise() //This is new
    {
      return View();
    }

    [HttpPost]
    public IActionResult AddExercise(Exercise exercise) //This was originally a post to Index
    {
      Workout.Post(exercise);
      return RedirectToAction("Index");
    }

    // public IActionResult Details(int id)
    // {
    //   var exercise = Workout.GetDetails(id);
    //   return View(exercise);
    // }

    // public IActionResult Edit(int id)
    // {
    //   var exercise = Workout.GetDetails(id);
    //   return View(exercise);
    // }

    // [HttpPost]
    // public IActionResult Details(int id, Exercise exercise)
    // {
    //   exercise.ExerciseId = id;
    //   Workout.Put(exercise);
    //   return RedirectToAction("Details", id);
    // }

    public IActionResult Delete(int id)
    {
      Workout.Delete(id);
      return RedirectToAction("Index");
    }
  }
}









using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessClient.Models;

namespace FitnessClient.Controllers
{
  public class WorkoutsController : Controller
  {
    public IActionResult Index()
    {
      var allExercises = Workout.GetExercises();
      return View(allExercises);
    }

    [HttpPost]
    public IActionResult Index(Exercise exercise)
    {
      Workout.Post(exercise);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var exercise = Workout.GetDetails(id);
      return View(exercise);
    }

    public IActionResult Edit(int id)
    {
      var exercise = Workout.GetDetails(id);
      return View(exercise);
    }

    [HttpPost]
    public IActionResult Details(int id, Exercise exercise)
    {
      exercise.ExerciseId = id;
      Workout.Put(exercise);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Workout.Delete(id);
      return RedirectToAction("Index");
    }
  }
}
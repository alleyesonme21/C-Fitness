using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessClient.Models;

namespace FitnessClient.Controllers
{
  public class ExercisesController : Controller
  {
    public IActionResult Index()
    {
      var allExercises = Exercise.GetExercises();
      return View(allExercises);
    }

    [HttpPost]
    public IActionResult Index(Exercise exercise)
    {
      Exercise.Post(exercise);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var exercise = Exercise.GetDetails(id);
      return View(exercise);
    }

    public IActionResult Edit(int id)
    {
      var exercise = Exercise.GetDetails(id);
      return View(exercise);
    }

    [HttpPost]
    public IActionResult Details(int id, Exercise exercise)
    {
      exercise.ExerciseId = id;
      Exercise.Put(exercise);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Exercise.Delete(id);
      return RedirectToAction("Index");
    }
  }
}
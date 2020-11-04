using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace FitnessClient.Controllers
{
  public class WorkoutsController : Controller
  {
    private readonly FitnessClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public WorkoutsController(UserManager<ApplicationUser> userManager, FitnessClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }
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

  //  [HttpPost]
  //   public void Post([FromBody] Exercise exercise)
  //   {
  //     _db.Exercises.Add(exercise);
  //     _db.SaveChanges();
  //   }

    public IActionResult Delete(int id)
    {
      Workout.Delete(id);
      return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult EasyWorkout(int id)
    {
      // bool exerciseComplete = true;
      return RedirectToAction("Index", "Account");
    }

    [HttpPost]
    public IActionResult MediumWorkout(int id)
    {
      return RedirectToAction("Index", "Account");
    }
        [HttpPost]
    public IActionResult HardWorkout(int id)
    {
      return RedirectToAction("Index", "Account");
    }
        [HttpPost]
    public IActionResult ArmWorkout(int id)
    {
      return RedirectToAction("Index", "Account");
    }
        [HttpPost]
    public IActionResult AbsWorkout(int id)
    {
      return RedirectToAction("Index", "Account");
    }
        [HttpPost]
    public IActionResult LegsWorkout(int id)
    {
      return RedirectToAction("Index", "Account");
    }
        [HttpPost]
    public IActionResult CardioWorkout(int id)
    {
      return RedirectToAction("Index", "Account");
    }
    [HttpPost]
    public ActionResult Index(string Name)
    {
      var allExercises = Workout.GetExercises();
      var someExercises = allExercises.Where(x => x.Name.Contains(Name)).ToList();
      var SortedList = someExercises.OrderBy(o => o.Name).ToList();
      return View("Index", SortedList);
    }
  }
}









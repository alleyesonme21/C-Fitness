using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Fitness.Models;

namespace Fitness.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExercisesController : ControllerBase
  {
    private FitnessContext _db;

    public ExercisesController(FitnessContext db)
    {
      _db = db;
    }

    // GET api/exercises
    [HttpGet]
    public ActionResult<IEnumerable<Exercise>> Get()
    {
      return _db.Exercises.ToList();
    }

    // POST api/exercises
    [HttpPost]
    public void Post([FromBody] Exercise exercise)
    {
      _db.Exercises.Add(exercise);
      _db.SaveChanges();
    }

    // GET api/exercises/5
    [HttpGet("{id}")]
    public ActionResult<Exercise> Get(int id)
    {
        return _db.Exercises.FirstOrDefault(entry => entry.ExerciseId == id);
    }
        // PUT api/exercises/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Exercise exercise)
    {
        exercise.ExerciseId = id;
        _db.Entry(exercise).State = EntityState.Modified;
        _db.SaveChanges();
    }
    // DELETE api/exercises/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var exerciseToDelete = _db.Exercises.FirstOrDefault(entry => entry.ExerciseId == id);
      _db.Exercises.Remove(exerciseToDelete);
      _db.SaveChanges();
    }
  }
}
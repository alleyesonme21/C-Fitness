using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessClient.Models;

namespace FitnessClient.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
        {
            return RedirectToAction("Index", "Exercises");
        }

    // public IActionResult Privacy()
    // {
    //   return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
  }
}

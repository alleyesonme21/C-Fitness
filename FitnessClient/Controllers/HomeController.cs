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
    [HttpGet("/")]
    public IActionResult Index()
        {
            return View();
        }

  }
}

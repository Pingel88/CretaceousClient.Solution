using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CretaceousClient.Models;

namespace CretaceousClient.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }
  }
}
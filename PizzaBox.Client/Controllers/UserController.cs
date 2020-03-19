using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class UserController : Controller
  {
    [HttpGet]
    public IActionResult History()
    {
      return View("User");
    }

    [HttpPost]
    public IActionResult Order()
    {
      return View("User");
    }
  }
}
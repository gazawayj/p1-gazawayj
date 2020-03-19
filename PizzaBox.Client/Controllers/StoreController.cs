using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  public class StoreController : Controller
  {
    [HttpGet]
    public IActionResult History()
    {
      return View("Store");
    }

    // [HttpPost]
    // public IActionResult Login(StoreViewModel store)
    // {
    //   if (!ModelState.IsValid)
    //   {
    //     return View(store);
    //   }

    //   if (store.Store == false)
    //   {
    //     return View("User");
    //   }
    //   return View("Store");
    // }

    // public IActionResult Logout()
    // {
    //   return View();
    // }
  }
}
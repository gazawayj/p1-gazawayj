using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  public class AccountController : Controller
  {
    private static readonly PizzaBoxRepository _pbr = new PizzaBoxRepository();


    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login(AccountViewModel account)
    {
      if (!ModelState.IsValid)
      {
        if (_pbr.CheckAccount(account.Username, account.Password))
        {
          if (account.Store)
            return View("Store");
        }
        return View("User");

      }
      return View(account);
    }

    public IActionResult Logout()
    {
      return View();
    }
  }
}
using Microsoft.AspNetCore.Mvc;
using DarpinosPizza.Models.ViewModels;
using DarpinosPizza.Models;
using System.ComponentModel;

namespace DarpinosPizza.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Name = "Victor", Email = "VictorOdarp@gmail.com" });
            users.Add(new User { Id = 2, Name = "Carlos", Email = "CarlosMagno@gmail.com" });
            return View(users);
        }
    }
}

using LookingforYatchs.Models;
using Microsoft.AspNetCore.Mvc;

namespace LookingforYatchs.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Kayıt model)
        {
            return View();
        }
    }
}

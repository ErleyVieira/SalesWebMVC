using SalesWebMVC.Models.LoginData;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Login login = new();

            login.email = "daviemailarroba.com";
            login.senha = "Soulevans1#";

            return View(login);
        }
    }
}

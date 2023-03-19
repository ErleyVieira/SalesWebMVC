using Microsoft.AspNetCore.Mvc;

namespace SalesW.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

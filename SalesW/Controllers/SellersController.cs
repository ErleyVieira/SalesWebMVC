using Microsoft.AspNetCore.Mvc;
using SalesW.Models;
using SalesW.Services;

namespace SalesW.Controllers
{
    public class SellersController : Controller
    {

        public readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }


        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

    }
}

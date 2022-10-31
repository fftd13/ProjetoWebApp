using Microsoft.AspNetCore.Mvc;
using SalesMVC.Services;

namespace SalesMVC.Controllers
{    
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerservice)
        {
            _sellerService = sellerservice;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

    }
}

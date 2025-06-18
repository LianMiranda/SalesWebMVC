using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        // GET
        public IActionResult Index()
        {
            var list = _sellerService.FindAll(); 
            return View(list);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        // CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Save(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
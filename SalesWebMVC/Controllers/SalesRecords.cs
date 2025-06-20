using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SalesRecords : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> SimpleSearch()
        {
            return View();
        }
        
        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
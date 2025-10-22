using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

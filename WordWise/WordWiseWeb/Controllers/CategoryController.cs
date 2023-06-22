using Microsoft.AspNetCore.Mvc;

namespace WordWiseWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

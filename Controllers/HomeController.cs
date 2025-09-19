using Microsoft.AspNetCore.Mvc;

namespace Myshop.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
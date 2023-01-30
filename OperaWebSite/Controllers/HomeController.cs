using Microsoft.AspNetCore.Mvc;

namespace OperaWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag
            return View();
        }
    }
}

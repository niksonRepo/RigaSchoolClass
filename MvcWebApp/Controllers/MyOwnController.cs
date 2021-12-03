using Microsoft.AspNetCore.Mvc;

namespace MvcWebApp.Controllers
{
    public class MyOwnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;

namespace MvcWebApp.Controllers
{
    public class MyOwnController : Controller
    {
        public IActionResult Index()
        {
            var model = new MyOwnModel()
            {
                MyOwnName = "Andris",
                MyOwnEmail = @"andris@inbox.lv",
                MyOwnPhone = "+371 22887458"
            };

            ViewData["dataValue"] = "test data";
            return View(model);
        }

        public IActionResult ModifyViewData(string dataValue)
        {
            return RedirectToAction("Index");
        }

        public void ModifyViewData1(string dataValue)
        {
            ViewData["Title"]= dataValue;
        }
    }
}

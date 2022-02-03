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

        [HttpPost]
        public JsonResult ModifyViewData(MyOwnModel dataModel)
        {
            try
            {
                var model = new MyOwnModel()
                {
                    MyOwnName = dataModel.MyOwnName,
                    MyOwnEmail = dataModel.MyOwnEmail,
                    MyOwnPhone = dataModel.MyOwnPhone
                };

                return Json(new {model, status = "Success"});
            }
            catch (Exception ex)
            {
                return Json(new {status = "Fail", exceptionMessage = ex.Message});
            }
        }

        public void ModifyViewData1(string dataValue)
        {
            ViewData["Title"]= dataValue;
        }
    }
}

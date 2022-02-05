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
                var nameValidationMessage = "";

                if (dataModel.MyOwnName.Length < 10)
                {
                    nameValidationMessage = "Name is not valid. Please use less then 10 symbols";
                }

                return Json(new {nameMassege = nameValidationMessage, status = "Fail"});
            }
            catch (Exception ex)
            {
                return Json(new {status = "Fail", exceptionMessage = ex.Message});
            }
        }

        public void ModifyViewData1()
        {

        }
    }
}

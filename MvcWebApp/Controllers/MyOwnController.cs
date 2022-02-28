using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;
using Newtonsoft.Json;

namespace MvcWebApp.Controllers
{
    public class MyOwnController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MyOwnController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

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
        
        public async Task<IActionResult> GetMovie(string movieTitle)
        {
            var url = $"https://localhost:7128/api/WeatherForecast/GetMovies/{movieTitle}";

            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync(url);
            var result = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

            if ( response.IsSuccessStatusCode )
            {
               // return View(result);
            }

            return View(null);
        }
    }
}

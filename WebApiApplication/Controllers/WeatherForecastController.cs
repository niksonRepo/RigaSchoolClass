using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace WebApiApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("{id:int}")]
        public int GetId(int id)
        {
            _logger.LogWarning("test warning");
            return id;
        }

        [HttpGet]
        [Route("{name}")]
        public string GetName(string name)
        {
            _logger.LogWarning("test warning");
            return name;
        }

        [HttpGet]
        [Route("{movieTitle}")]
        public async Task<string?> GetMovies(string movieTitle)
        {
            var url = @"http://www.omdbapi.com/?t={" + movieTitle + @"}&apikey=3e9b408";

            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync(url);

            if ( response.IsSuccessStatusCode )
            {
                return JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result).ToString();
            }

            return "";
        }
    }
}
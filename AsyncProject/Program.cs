using Newtonsoft.Json;
namespace AsyncProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetResults();
            Console.ReadLine();
        }

        public static async void GetResults()
        {
            //var task1 = Task.Run(async () =>
            //{
            //    await WriteTodayDate();
            //});

            //var task2 = Task.Run(async () =>
            //{
            //    await WriteYesterdayDate();
            //});

            var task3 = Task.Run(async () =>
            {
                var movies = await GetMoviesAsync("Batman");
                var jsonString = movies.Content.ReadAsStringAsync().Result;

                Console.WriteLine(JsonConvert.DeserializeObject(jsonString));
            });

            //var awaiter = task1.GetAwaiter();
            //var result = awaiter.GetResult();

            //await WriteTodayDate();
            //await WriteYesterdayDate();

            var asyncResults = await GetTodayDate();
        }

        public static async Task<HttpResponseMessage> GetMoviesAsync ( string movieTitle )
        {
            var url = @"http://www.omdbapi.com/?t={" + movieTitle + @"}&apikey=3e9b408";
            //var url = @"https://localhost:7128/WeatherForecast";

            using ( var httpClient = new HttpClient () )
            {
                return await httpClient.GetAsync ( url );
            }
        }

        //Return string type result
        private static async Task<string> GetTodayDate()
        {
            await Task.Delay(100);
            return $"Today is {DateTime.Today:D}\n";
        }

        //Return string type result
        private static async Task<string> GetYesterdayDate()
        {
            await Task.Delay(100);
            return $"Yesterday was {DateTime.Now.AddDays(-1):yyyy-MM-dd}";
        }

        //I void type method
        private static async Task WriteTodayDate()
        {
            Console.WriteLine( await GetTodayDate());
        }

        //I void type method
        private static async Task WriteYesterdayDate()
        {
            Console.WriteLine( await GetYesterdayDate());
        }

        public static string GetStringResult_1() => "Result_1";
        public static string GetStringResult_2() => "Result_2";
        public static string GetStringResult_3() => "Result_3";

        public static void WriteResult_1() => Console.WriteLine("Result_1");
        public static void WriteResult_2() => Console.WriteLine("Result_2");
        public static void WriteResult_3() => Console.WriteLine("Result_3");
    }
}
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hybrid.Core.Data
{
    public class WeatherForecastService
    {
        private static string[] Cities = new string[] { "Minsk", "Moscow", "Kiev" };

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return await Task.WhenAll(Cities.Select(c => FetchWeatherAsync(startDate, c)));
        }

        private async Task<WeatherForecast> FetchWeatherAsync(DateTime startDate, string city)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=[your_openweathermap_api_key]");
            var client = new HttpClient();

            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var weatherJObject = JObject.Parse(responseString);

            return
                new WeatherForecast
                {
                    Date = startDate,
                    Summary = weatherJObject["weather"][0]["description"].Value<string>(),
                    TemperatureF = weatherJObject["main"]["temp"].Value<int>()
                };

        }
    }
}

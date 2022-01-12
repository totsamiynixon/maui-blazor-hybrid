using System;

namespace Hybrid.Core.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC => (TemperatureF - 32) * 5 / 9;

        public int TemperatureF { get; set;  }

        public string Summary { get; set; }
    }
}

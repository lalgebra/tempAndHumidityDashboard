using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace BlazorApp.Shared
{
    public class WeatherForecast : TableEntity
    {
        
        public double Humidity { get; set; }
        public double TemperatureC { get; set; }

        public string HumidityLevel { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public DateTime DateTime { get; set; }
        public DateTime Date => this.Timestamp.DateTime;
    }
  
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace ReadWeathercastDatafromJSON
{
   public class JsonRead
    {
        public void Climate()
        {
            string Filepath = "C:\\Users\\TEC BUDDY\\Downloads\\WeatherForecast-Result.json";
            string Json = File.ReadAllText(Filepath);
            List<WeatherForecast> Result = JsonConvert.DeserializeObject<List<WeatherForecast>>(Json);
            foreach(var source in Result)
            {
                Console.WriteLine($"date:{source.Date},summary:{source.Summary},temperatureC:{source.TemperatureC},temperatureF:{source.TemperatureF}");
            }
        }
    }
}

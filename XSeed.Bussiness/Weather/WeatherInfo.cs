using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSeed;
using XSeed.Data.ViewModel;

namespace XSeed.Bussiness.Weather
{
    public class WeatherInfo : IWeatherInfo
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> WeatherInfoMethod()
        {
            WeatherModel model = new WeatherModel();
            return (IEnumerable<WeatherForecast>)model.WeatherModelMethod();
        }


        //public IEnumerable<WeatherForecast> WeatherInfoMethod()
        //{
        //    WeatherModel model = new WeatherModel();
        //    return (IEnumerable<WeatherForecast>)model.WeatherModelMethod();
        //}
    }
}

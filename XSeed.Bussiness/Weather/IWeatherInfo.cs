using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSeed.Data.ViewModel;

namespace XSeed.Bussiness.Weather
{
    public interface IWeatherInfo 
    {
        IEnumerable<WeatherForecast> WeatherInfoMethod();
    }
}

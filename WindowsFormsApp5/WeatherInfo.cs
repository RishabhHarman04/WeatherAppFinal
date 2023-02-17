using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{

    internal struct WheatherData
    {
        public int humidity, atmosphere, temperature;

        public WheatherData(int humidity, int atmosphere, int temperature)
        {
            this.humidity = humidity;
            this.atmosphere = atmosphere;
            this.temperature = temperature;
        }
    }

    internal class WeatherInfo
    {
        Random rnd;

        public WeatherInfo()
        {
            rnd = new Random();
        }

        public WheatherData GetWeatherData(string location)
        {
           
            return new WheatherData(rnd.Next(0, 101), rnd.Next(700, 1500), rnd.Next(0, 101));
        }

    }

}

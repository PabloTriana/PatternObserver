using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature, humidity, pressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData; 
            weatherData.registerObserver(this);
        }
        public void display()
        {
           if(temperature <= 10)
           {
                Console.WriteLine("Forescast: Rainy day");
           }
           if(temperature > 11 && temperature <= 30)
           {
                Console.WriteLine("Forescat: Cloudy day");
           }
           if(temperature > 31 && temperature <= 70)
           {
                Console.WriteLine("Forescat: partly cloudy day");
           }
           if(temperature > 71 && temperature <= 188)
           {
                Console.WriteLine("Forescat: Sunny day");
           }
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            display();
        }
    }
}

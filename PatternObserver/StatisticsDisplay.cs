using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    public  class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature, humidity, pressure;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
        public void display()
        {
            Console.WriteLine("Temperature >> Max:" + temperature + " / Min:" + humidity + " / Pressure:" + pressure);
        }

        
    }
}

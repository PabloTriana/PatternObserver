using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {   Random rand = new Random();
           
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            while (true)
            {
                Console.WriteLine("Alumno: Jose Pablo Triana Corvera - Numero Control: C18210381");
                Console.WriteLine("*********************Weather Station*************************");
                weatherData.setMeasurements(rand.Next(0, 118), rand.Next(17, 70), rand.Next(10, 70));
                Console.WriteLine("*************************************************************");
                Thread.Sleep(3500);
                Console.Clear();
            }
        }
    }
}

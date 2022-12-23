namespace DesignPatters.Studies.ObserverPattern;

public static class ObserverPatternDemo
{
    public static void RunWeatherORamaDemo()
    {
        Console.WriteLine("----------- Welcome to Weather-O-Rama ------------\n");
        Console.WriteLine("Showing current meteorological information: \n");

        var weatherData = new WeatherData();
        var currentConditionDisplay = new CurrentConditionDisplay(weatherData);
        var forecastDisplay = new ForecastDisplay(weatherData);
        var statisticsDisplay = new StatisticsDisplay(weatherData);
        var heatIndexDisplay = new HeatIndexDisplay(weatherData);

        while (true)
        {
            var random = new Random();
            
            // Updating Observer Data
            weatherData.SetWeatherData(
                (float)random.NextDouble(), 
                (float)random.NextDouble(), 
                (float)random.NextDouble());

            // Wait 3s to show updated data
            Thread.Sleep(3000);
            Console.WriteLine("--- New data will be updated on Observer... \n");
            Thread.Sleep(1000);
        }   
    }
}
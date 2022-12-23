using DesignPatters.Studies.ObserverPattern.Interfaces;

namespace DesignPatters.Studies.ObserverPattern;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float maxTemp = 0.0f;
    private float minTemp = 200;
    private float tempSum= 0.0f;
    private int numReadings;
    private WeatherData weatherData;

    public StatisticsDisplay(WeatherData weatherData) 
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    
    public void Update(float temperature, float humidity, float pressure)
    {
        tempSum += temperature;
        numReadings++;

        if (temperature > maxTemp) {
            maxTemp = temperature;
        }
 
        if (temperature < minTemp) {
            minTemp = temperature;
        }

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"--- Statistics Display Info         --> " +
                          $"Avg/Max/Min Temperature: {(tempSum / numReadings)} / " +
                          $"{maxTemp} / {minTemp}");
    }
}
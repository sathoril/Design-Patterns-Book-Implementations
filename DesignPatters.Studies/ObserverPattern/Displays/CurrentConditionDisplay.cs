using DesignPatters.Studies.ObserverPattern.Interfaces;

namespace DesignPatters.Studies.ObserverPattern;

/// <summary>
/// Concrete Observer
/// </summary>
public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private float Temperature;
    private float Humidity;
    private WeatherData WeatherData;

    public CurrentConditionDisplay(WeatherData weatherData)
    {
        this.WeatherData = weatherData;
        this.WeatherData.RegisterObserver(this);
    }
    
    public void Update(float temperature, float humidity, float pressure)
    {
        this.Temperature = temperature;
        this.Humidity = humidity;
        this.Display();
    }

    public void Display()
    {
        Console.WriteLine($"--- Current Condition Display Info  --> Temp: {Temperature} C | Humidity: {Humidity}");
    }
}
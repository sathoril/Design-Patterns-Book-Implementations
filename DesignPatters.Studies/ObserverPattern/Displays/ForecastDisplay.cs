using DesignPatters.Studies.ObserverPattern.Interfaces;

namespace DesignPatters.Studies.ObserverPattern;

/// <summary>
/// Concrete Observer
/// </summary>
public class ForecastDisplay : IObserver, IDisplayElement
{
    private float currentPressure = 29.92f;  
    private float lastPressure;
    private WeatherData WeatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        this.WeatherData = weatherData;
        this.WeatherData.RegisterObserver(this);
    }
    
    public void Update(float temperature, float humidity, float pressure)
    {
        lastPressure = currentPressure;
        currentPressure = pressure;

        Display();
    }

    public void Display()
    {
        if (currentPressure > lastPressure) {
            Console.WriteLine("--- Forecast Display                --> Improving weather on the way!");
        } else if (currentPressure == lastPressure) {
            Console.WriteLine("--- Forecast Display                --> More of the same");
        } else if (currentPressure < lastPressure) {
            Console.WriteLine("--- Forecast Display                --> Watch out for cooler, rainy weather");
        }
    }
}
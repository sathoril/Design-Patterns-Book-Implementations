using DesignPatters.Studies.ObserverPattern.Interfaces;

namespace DesignPatters.Studies.ObserverPattern;

public class WeatherData : ISubject
{
    public WeatherData()
    {
        this.Observers = new List<IObserver>();
    }

    private List<IObserver> Observers;
    private float Temperature;
    private float Humidity;
    private float Pressure;

    /// <summary>
    /// This method gets called whenever the weather measurements
    /// have been updated
    /// </summary>
    public void MeasurementsChanged()
    {
        this.NotifyObservers();   
    }

    public void RegisterObserver(IObserver o)
    {
        this.Observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        this.Observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update(this.Temperature, this.Humidity, this.Pressure);
        }
    }

    public void SetWeatherData(float temperature, float humidity, float pressure)
    {
        this.Humidity = humidity;
        this.Temperature = temperature;
        this.Pressure = pressure;
        
        this.MeasurementsChanged();
    }
}
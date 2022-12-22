namespace DesignPatters.Studies.ObserverPattern;

public abstract class WeatherData
{
    public abstract void GetTemperature();
    public abstract void GetHumidity();
    public abstract void GetPressure();
    
    /// <summary>
    /// This method gets called whenever the weather measurements
    /// have been updated
    /// </summary>
    public abstract void MeasurementsChanged();
}
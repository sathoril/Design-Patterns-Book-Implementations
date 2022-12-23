namespace DesignPatters.Studies.ObserverPattern.Interfaces;

/// <summary>
/// The Observer interface, defines which methods a class that needs to be an observer should implement.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// This method, is the method that the Subject will call from each observer on its track
    /// to notify about any changes.
    /// </summary>
    /// <param name="temperature"></param>
    /// <param name="humidity"></param>
    /// <param name="pressure"></param>
    public void Update(float temperature, float humidity, float pressure);
}